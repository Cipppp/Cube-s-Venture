using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float delayTime;
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Go());
    }
    IEnumerator Go()
    {
        while(true)
        {
            animation.Play();
            yield return new WaitForSeconds(1f + delayTime);
        }

    }
}
