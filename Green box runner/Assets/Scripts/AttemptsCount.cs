using UnityEngine;
using UnityEngine.SceneManagement;

public class AttemptsCount : MonoBehaviour
{
    //
    // SCRIPT STORING THE ATTEMPTS COUNT 
    // Not destroyed on load object
    //

    //public Text attemptsText;

    [HideInInspector] public static int attemptsCount;
    [HideInInspector] public static int attemptsNum;
    [HideInInspector] public static float highscore;

    [HideInInspector] public static AttemptsCount instance;

    private void Awake()
    {
		//Check if AttemptsCount (duplicate) object doesn't exists
        if (instance == null)
        {
            instance = this;
        }
		//Destroy the duplicates
        else
        {
            Destroy(gameObject);
            return;
        }

        //Reset values
        highscore = 0;
        attemptsCount = 1;
        attemptsNum = 0;
		
		//Set this script not ti be destroyed on load
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
		//If current scene isn't Level_2, destroy this object
		
        if (SceneManager.GetActiveScene().name != "Level_2")
        {
            Destroy(gameObject); 
        }
    }
}
