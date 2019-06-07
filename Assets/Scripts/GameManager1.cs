
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager1 : MonoBehaviour
{
    //Count
   //public int currentScore;
   //public int highscore;
    public int coinCount;
    private int totalCoinCount;
   //public int currentLevel = 1;

    //Timer variables
    public Rect timerRect;
   public float startTime;
    private string currentTime;
   //public Color warningColorTimer;
    //public Color defaultColorTimer;


    //GUI skin
    public GUISkin skin;

    //References
    public GameObject coinParent;
     
    private bool completed = false;
    //private bool showWinScreen = false;
    public int winScreenWidth, winScreenHeight;
    //void Update()
    //{
    //   if(!completed)
    //    {
    //        startTime = startTime - Time.deltaTime;
    //        currentTime = string.Format("{0:0.0}", startTime);
    //        if (startTime <= 0)
    //        {
    //            startTime = 0;
    //           // SceneManager.LoadScene("main_menu");
    //        }
    //    }
    //}
   void Start()
    {

        totalCoinCount = coinParent.transform.childCount;
       // if (PlayerPrefs.GetInt("Level Completed") > 1)
       // {
       //     currentLevel = PlayerPrefs.GetInt("Level Completed");

       // }
       //else{
       //     currentLevel = 1;
       // }

    }
    //public void completelevel()
    //{
    //    showwinscreen = true;
    //    completed = true;
    // }

    //public void LoadNexLevel()
    //{

    //    if (currentLevel < 3)
    //    {

    //        currentLevel++;
    //        SceneManager.LoadScene(currentLevel);
    //        }
    //    else
    //    {
    //        SceneManager.LoadScene("Level 3");
    //    }
    //}

    //void SaveGame()
    //{
    //    PlayerPrefs.SetInt("Level Completed", currentLevel);
    //    PlayerPrefs.SetInt("Level " + currentLevel.ToString() + " score", currentScore);
    //}






    void OnGUI()
    {
        GUI.skin = skin;
       /* if(startTime < 5f)       
            skin.GetStyle("Timer").normal.textColor = warningColorTimer; 
        else 
            skin.GetStyle("Timer").normal.textColor = defaultColorTimer;
        */
        GUI.Label(timerRect, currentTime, skin.GetStyle ("Timer"));
        GUI.Label(new Rect(40, 20, 100, 100), coinCount.ToString()+"/"+ totalCoinCount.ToString());


        //if(showWinScreen)
        //{
        //    Rect winScreenRect = new Rect(Screen.width / 2 - (Screen.width * .5f / 2), Screen.height / 2 - (Screen.height * .5f / 2), Screen.width * .5f, Screen.height * .5f);
        //    GUI.Box(winScreenRect, "Yeah");
        //    int gameTime = (int)startTime;
        //    currentScore = coinCount * gameTime;
           
        //    if (GUI.Button(new Rect(winScreenRect.x + winScreenRect.width - 170, winScreenRect.y + winScreenRect.height - 60, 150, 40), "Continue"))
        //    {
        //        LoadNexLevel();
        //    }

        //    if (GUI.Button(new Rect(winScreenRect.x + 20, winScreenRect.y + winScreenRect.height - 60, 100, 40), "Quit"))
        //    {
        //        SceneManager.LoadScene("main_menu");

        //      // Application.LoadLevel("main_menu");
        //        Time.timeScale = 1f;
        //        //currentLevel += 1;
        //        //SaveGame();       

        //    }
        //    GUI.Label(new Rect(winScreenRect.x + 20, winScreenRect.y + 40, 300, 50), currentScore.ToString() + " Score");
        //    GUI.Label(new Rect(winScreenRect.x + 20, winScreenRect.y + 80, 300, 50), "Completed level " + currentLevel);
        //}
    }
}
