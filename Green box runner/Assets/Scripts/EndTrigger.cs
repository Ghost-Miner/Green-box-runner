using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;	//GameManager

    public GameObject player;		//Player object

    public GameObject loadingPanel;	//loading Panel object

    public void OnTriggerEnter()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            gameManager.CompleteLevel();
        }
        else
        {
            loadingPanel.SetActive(true);

            score.levelEnded = true;
            score.levelNum += 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
