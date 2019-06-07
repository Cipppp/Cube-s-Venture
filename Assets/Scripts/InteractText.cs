using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InteractText : MonoBehaviour
{
    private string loadPrompt;
    private int completedLevel;

  

    void OnTriggerStay(Collider other)
    {
        
            loadPrompt = "[E] to pick up key. ";


    }

    void OnTriggerExit()
    {
        loadPrompt = "";
    }

    void OnGUI()
    {
        GUI.Label(new Rect(30, Screen.height * .9f, 200, 40), loadPrompt);
    }


}
