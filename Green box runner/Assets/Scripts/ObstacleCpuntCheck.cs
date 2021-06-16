using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCpuntCheck : MonoBehaviour
{
    public static int obstacleCount;

    public GameObject obstacleSpawn;
    public Transform OBstacleTransform;

    public float timeVal;
    // Start is called before the first frame update
    void Start()
    {
        //obstacleCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Instantiate(obstacleSpawn, transform.position = new Vector3(0, 20, 25), OBstacleTransform.rotation);
        }

        if (timeVal > 0f)
        {
            timeVal -= Time.deltaTime;
            Debug.Log("Time: " + timeVal);
        }
        else
        {
            timeVal = 3f;
            timeVal = timeVal - Time.deltaTime;
            //Instantiate(obstacleSpawn, transform.position = new Vector3(0, 20, -25), OBstacleTransform.rotation);
            Debug.Log("Time: " + timeVal);
        }



        /*if (obstacleCount != 7)
        {
            Debug.Log("prazdny, " + obstacleCount);
        }
        else
        {
            Debug.Log("plny," + obstacleCount);
        }*/

    }
}
