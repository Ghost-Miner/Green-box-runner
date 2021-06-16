using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingPanel;

    public void PlayGame()
    {
        loadingPanel.SetActive(true);
        Time.timeScale = 1f;
        Debug.Log("Game started");
        SceneManager.LoadScene("Level_2");
    }
    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
    public void MoreGames()
    {
        Debug.Log("Opening link");
        Application.OpenURL("https://ghost-miner.itch.io/");
    }
    public void Options()
    {
        Debug.Log("opening Options");
        SceneManager.LoadScene("Options");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
