using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool IsPaused = false;	//variable to check state of the menu
    public GameObject pauseMenu;			//The pause menu panel
    public GameObject pauseButton;			//Pause button, currently unused and played outside the canvas

    void Start()
    {
        //Debug.Log("SceneLoad TimeScale: " + Time.timeScale); // Used for debugging, disabled.
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused == true)
            {
                Resume();
                Debug.Log("Resumed");
            }
            else
            {
                Pause();
                Debug.Log("Paused");
            }
        }
        //Debug.Log("GAME TIME: " + Time.timeScale); // Used for debugging, disabled.
    }
	
	//Resume game method
    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        IsPaused = false;
    }

	//Pause game method
    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
    }
	
	//Quit to menu
    public void GoToMenu()
    {
        IsPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Exiting to Menu, TimeScale: " + Time.timeScale);
        SceneManager.LoadScene("MainMenu");
    }
}
