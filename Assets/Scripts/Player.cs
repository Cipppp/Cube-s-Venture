using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameManager1 manager;
    public float moveSpeed;
    public GameObject deathParticles;
    public bool usesManager = true;
    private int currentLevel = 1;

    private Vector3 input;
    private float maxSpeed = 5f;

    public Rigidbody rb;
    private Vector3 spawn;
    private int nextSceneToLoad;

    //public AudioClip[] audioClip;


    void Start()
    {

        spawn = transform.position;
        if (usesManager)
        {
            manager = manager.GetComponent<GameManager1>();
        }
        FindObjectOfType<AudioManager>().Play("BackgroundMusic");

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }


    //void FixedUpdate()
    //{
        //input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        //if (rb.velocity.magnitude < maxSpeed)
        //{
        //    rb.AddRelativeForce(input * moveSpeed);

        //}

        //if (transform.position.y < 1)
        //{
        //    FindObjectOfType<AudioManager>().Play("DeadSound");
        //    Die();
        //}

        //Physics.gravity = Physics.Raycast(transform.position, Vector3.down, .45f) ? Vector3.zero : new Vector3(0, -25f, 0);
    //}

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.transform.tag == "Enemy")
    //    {
    //        FindObjectOfType<AudioManager>().Play("DeadSound");
    //        Die();

    //    }

    //}

    void OnTriggerEnter(Collider other)
    {
        //if (other.transform.tag == "Enemy")
        //{
        //    FindObjectOfType<AudioManager>().Play("DeadSound");
        //    Die();

        //}
        if (other.transform.tag == "Coin")
        {
            if (usesManager)
                manager.coinCount++;

            FindObjectOfType<AudioManager>().Play("CoinSound");
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Goal")
        {
            //findobjectoftype<audiomanager>().play("winsound");

                          
                SceneManager.LoadScene(nextSceneToLoad);
          



        }
    }

    //void PlaySound(int clip)
    //{
    //    GetComponent<AudioSource>().clip = AudioClip[clip];
    //    GetComponent<AudioSource>().Play();
    //}

    void Die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270, 0, 0));//Quaternion.identity
        transform.position = spawn;
    }
}

