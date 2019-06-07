using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            //  GetComponent<Camera>().fieldOfView--;
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - .6f, transform.position.z + .2f);
            transform.Rotate(-2, 0, 0);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //  GetComponent<Camera>().fieldOfView++;
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + .6f, transform.position.z - .2f);
            transform.Rotate(-2, 0, 0);
        }
    }
}
