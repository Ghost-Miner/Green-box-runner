using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool IsPaused = false;
    public GameObject pauseMenu;
    public GameObject pauseButton;

    void Start()
    {
        //Debug.Log("SceneLoad TimeScale: " + Time.timeScale);
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
        //Debug.Log("GAME TIME: " + Time.timeScale);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void GoToMenu()
    {
        IsPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Exiting to Menu, TimeScale: " + Time.timeScale);
        SceneManager.LoadScene("MainMenu");
    }
}
