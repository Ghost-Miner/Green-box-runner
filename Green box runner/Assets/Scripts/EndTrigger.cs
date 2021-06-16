using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject player;

    public GameObject loadingPanel;

    public void OnTriggerEnter()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            gameManager.CompleteLevel();
        }
        else
        {
            loadingPanel.SetActive(true);

            score.score2 += 1000f;
            score.levelNum += 1;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //player.transform.position = new Vector3(0, 0.6f, 12);
        }
    }
}
