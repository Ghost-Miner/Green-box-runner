using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttemptsCount : MonoBehaviour
{
    //public Text attemptsText;

    public static int attemptsCount;
    public static int attemptsNum;

    public static AttemptsCount instance;

    public int crashes;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        attemptsCount = 1;
        attemptsNum = 0;

        DontDestroyOnLoad(gameObject);
    }

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
        if (SceneManager.GetActiveScene().name != "Level_2")
        {
            Destroy(gameObject);
        }
    }
}
