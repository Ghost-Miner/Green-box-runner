using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttemptsCount : MonoBehaviour
{
    //
	// SCRIPT STORING THE ATTEMPTS COUNT 
	// Not destroyed on load object
	//
	
	//public Text attemptsText;

    public static int attemptsCount;
    public static int attemptsNum;

    public static AttemptsCount instance;

    public int crashes;

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
        attemptsCount = 1;
        attemptsNum = 0;
		
		//Set this script not ti be destroyed on load
        DontDestroyOnLoad(gameObject);
    }
	
	//I think this is unused
    private void DontDestroyOnLoad()
    {

        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//If current scene isn't Level_2, destroy this object
		
        if (SceneManager.GetActiveScene().name != "Level_2")
        {
            Destroy(gameObject); 
        }
    }
}
