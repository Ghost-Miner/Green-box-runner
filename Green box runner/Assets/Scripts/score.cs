using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text attemptsText;

    private float totalScore;
    public Text levelText;

    public static float score2;
    public static int levelNum = 1;

    void Update()
    {
        totalScore = player.position.z + score2;
        scoreText.text = totalScore.ToString("0");
        levelText.text = "Level " + levelNum;

        attemptsText.text = attemptsText.text = "Attempts: " + AttemptsCount.attemptsCount;

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            player.transform.position = new Vector3(0, 0.6f, 990);
        }
    }
}
