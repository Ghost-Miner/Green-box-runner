using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public CobeControl movement;
    public GameObject GameOver;
    public GameObject pauseButton;
    public GameObject player;
    public Transform player2Tranf;

    //public Text attemptsText;
    #endregion

    private void FixedUpdate()
    {
        if (player.transform.rotation != player2Tranf.rotation && !gameHasEnded)
        {
            player.transform.rotation = player2Tranf.rotation;
            Debug.Log("GAMEMANAGER: Resetting player rotation");
        }
    }

    #region Game over event
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            AttemptsCount.attemptsCount++;// = AttemptsCount.attemptsNum + 1;
            AttemptsCount.attemptsNum++;
            //Debug.Log(AttemptsCount.attemptsCount);
            //Debug.Log(AttemptsCount.attemptsNum);

            //attemptsText.text = "Attempts: " + AttemptsCount.attempts;
            gameHasEnded = true;
            GameOver.SetActive(true);
            pauseButton.SetActive(false);

            Invoke("Restart", restartDelay);
        }
    }
    #endregion

    #region Comple level event
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        movement.enabled = false;
    }
    #endregion

    #region Secret Comple level event
    public void SecretEnd()
    {
        Debug.Log("You found the secret end!");
        completeLevelUI.SetActive(true);
        movement.enabled = false;
    }
    #endregion

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartCrash()
    {
        gameHasEnded = false;
        GameOver.SetActive(false);
        pauseButton.SetActive(false);

        player.transform.position = new Vector3(0, 0.6f, 0);
        player.transform.rotation = player2Tranf.rotation;

        movement.enabled = true;
    }
}