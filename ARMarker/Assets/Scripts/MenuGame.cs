using UnityEngine;

/// <summary>
/// This class is responsible for displaying UI elements to trigger animations of the AR character. 
/// I set up as public variables for character / anim with the idea that if we wanted to add more characters, we could be changing these
/// variables to interact with the character directly in front of the camera. 
/// Alejandro Munilla, Feb 13th, 2022. 
/// </summary>


public class MenuGame : MonoBehaviour
{
    //Rects and sizes of buttons. 
    private int buttonWidth;
    private Rect idleRect;
    private Rect walkRect;
    private Rect runRect;
    private Rect waveRect;
    private Rect quitRect;

    public Animator anim;                   //Animator of the character
    public GameObject humanoid;             //Character 

    //Textures to display on GUI to interact with animations. 
    [SerializeField]
    private Texture2D idle;
    [SerializeField]
    private Texture2D walk;
    [SerializeField]
    private Texture2D run;
    [SerializeField]
    private Texture2D wave;
 
    //To store screen orientation of the Android device, so when a change happens, GUI element sizes are recalculated to fit screen. 
    ScreenOrientation screenOrientation;


    void Start()
    {

        anim = humanoid.GetComponent<Animator>();
        screenOrientation = Screen.orientation;
        CalculateGUI();
    }

    private void CalculateGUI ()
    {
        if (screenOrientation == ScreenOrientation.LandscapeRight || screenOrientation == ScreenOrientation.LandscapeLeft)
        {
            buttonWidth = (int)(Screen.height * 0.20f);
        }
        else
        {
            buttonWidth = (int)(Screen.width * 0.20f);
        }
        
        idleRect = new Rect(0, 0, buttonWidth, buttonWidth);
        walkRect = new Rect(0, buttonWidth, buttonWidth, buttonWidth);
        runRect = new Rect(0, (2 * buttonWidth), buttonWidth, buttonWidth);
        waveRect = new Rect(0, (3 * buttonWidth), buttonWidth, buttonWidth);
        quitRect = new Rect(0, (4 * buttonWidth), buttonWidth, buttonWidth);
    }

    private void Update()
    {
        if (screenOrientation != Screen.orientation)
        {
            screenOrientation = Screen.orientation;
            CalculateGUI();
        }
    }



    private void OnGUI()
    {
        if (GUI.Button(idleRect, idle))
        {
            if (!anim.GetBool ("Grounded"))
            {
                anim.SetBool("Grounded", true);
            }
            anim.SetFloat("MoveSpeed", 0);

        }
        if (GUI.Button(walkRect, walk))
        {
            if (!anim.GetBool("Grounded"))
            {
                anim.SetBool("Grounded", true);
            }
            anim.SetFloat("MoveSpeed", 0.38f);

        }
        if (GUI.Button(runRect, run))
        {
            if (!anim.GetBool("Grounded"))
            {
                anim.SetBool("Grounded", true);
            }
            anim.SetFloat("MoveSpeed", 1.0f);
        }

        if (GUI.Button(waveRect, wave))
        {
            if (!anim.GetBool("Grounded"))
            {
                anim.SetBool("Grounded", true);
            }
            anim.SetTrigger("Wave");
        }

        if (GUI.Button(quitRect, "QUIT"))
        {
            Application.Quit();
        }

    }
}
