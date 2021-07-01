using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player; 			//Player's transform
    public Text scoreText; 				//Score display (Regular text, not TMP)
    public Text attemptsText; 			//Attempts display (Regular text, not TMP)
    public Text highscoree;             //Highscore text

    private float totalScore; 			//display score - player's z position + score2
    public Text levelText; 				//Level number display (Regular text, not TMP)

    public static float score2; 		//used to add 1 000 to the score every time the level is finished
    public static int levelNum = 1; 	//What level you're in counter

    public static bool levelEnded = false;

    [SerializeField] private bool warp = false;

    private void Start()
    {
        if (levelEnded)
        {
            score2 += 1000f;
        }

        levelEnded = false; warp = true;
    }

    void Update()
    {
        totalScore = player.position.z + score2; 	            //Add player's z posotion to score2

        scoreText.text = totalScore.ToString("0"); 	            //Display the score
        levelText.text = "Level " + levelNum; 		            //Display the level

        highscoree.text = "Highscore: " + AttemptsCount.highscore.ToString("0");   //Display highscore

        attemptsText.text = attemptsText.text = "Attempts: " + AttemptsCount.attemptsCount; //Display number of attempts

        if (totalScore > AttemptsCount.highscore)
        {
            AttemptsCount.highscore = totalScore;
            Debug.Log("SCORE: " + AttemptsCount.highscore);
        }

		// A "secret" debug function used to instantly jump to the end oif the level. 
		// Should NOT be included in the final/public build or at lest hidden under a key combination or something.
		
        if (Input.GetKeyDown(KeyCode.LeftAlt) && warp)
        {
            player.transform.position = new Vector3(0, 0.6f, 990);
        }
    }
}
