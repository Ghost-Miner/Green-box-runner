using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player; 			//Player's transform
    public Text scoreText; 				//Score display (Regular text, not TMP)
    public Text attemptsText; 			//Attempts display (Regular text, not TMP)

    private float totalScore; 			//display score - player's z position + score2
    public Text levelText; 				//Level number display (Regular text, not TMP)

    public static float score2; 		//used to add 1 000 to the score every time the level is finished
    public static int levelNum = 1; 	//What level you're in counter

    void Update()
    {
        totalScore = player.position.z + score2; 	// add player's z posotion to score2
        scoreText.text = totalScore.ToString("0"); 	//Display the score
        levelText.text = "Level " + levelNum; 		//Display the level

        attemptsText.text = attemptsText.text = "Attempts: " + AttemptsCount.attemptsCount; //Display number of attempts


		// A "secret" debug function used to instantly jump to the end oif the level. 
		// Should NOT be included in the final/public build or at lest hidden under a key combination or something.
		
        if (Input.GetKeyDown(KeyCode.LeftAlt)) 
        {
            player.transform.position = new Vector3(0, 0.6f, 990);
        }
    }
}
