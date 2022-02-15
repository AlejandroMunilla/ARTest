using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    ////Rects and sizes of buttons. 
    private Rect logoRect;
    private Rect labelRect;
    private Rect startRect;
    private Rect exitRect;
    private int buttonWidth;
    private int buttonHeight;

    public Texture2D logo;

    private string label = "AR TEST. BY ALEJANDRO MUNILLA";
    private string start = "START";
    private string exit = "QUIT";

    //To store screen orientation of the Android device, so when a change happens, GUI element sizes are recalculated to fit screen. 
    ScreenOrientation screenOrientation;

    // Start is called before the first frame update
    void Start()
    {
        //All GUI buttons are made as a % of the screen, to fit all resolutions. By playing with these values we may fine tune 
        //how buttons are displayed. 
        if (screenOrientation == ScreenOrientation.LandscapeRight || screenOrientation == ScreenOrientation.LandscapeLeft)
        {
            buttonWidth = (int)(Screen.height * 0.2f);
            buttonHeight = (int)(Screen.height * 0.2f);
        }
        else
        {
            buttonWidth = (int)(Screen.width * 0.33f);
            buttonHeight = (int)(Screen.height * 0.2f);
        }

        
        logoRect = new Rect(Screen.width * 0.25f, Screen.height * 0.1f, Screen.width * 0.5f, Screen.width * 0.1f);
        labelRect = new Rect(Screen.width * 0.30f, Screen.height * 0.1f + buttonHeight, Screen.width * 0.5f, Screen.width * 0.1f);
        startRect = new Rect(Screen.width * 0.33f, Screen.height * 0.45f, buttonWidth, buttonHeight);
        exitRect = new Rect(Screen.width * 0.33f, Screen.height * 0.45f + buttonHeight, buttonWidth, buttonHeight);
        screenOrientation = Screen.orientation;
    }

    private void Update()
    {
        //If device orientation changes, we re-calculate values. 
        if (screenOrientation != Screen.orientation)
        {
            Start();
        }
    }

    private void OnGUI()
    {
        GUI.DrawTexture(logoRect, logo);
        GUI.Label(labelRect, label);

        if (GUI.Button(startRect, start))
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("SampleScene");
        }
        if (GUI.Button(exitRect, exit))
        {
            Application.Quit();
        }
    }
}
