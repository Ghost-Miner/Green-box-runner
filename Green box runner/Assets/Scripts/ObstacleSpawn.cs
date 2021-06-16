using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private Rigidbody obstacleRB;

    public Transform obstacleTransf;

    public float roation;

    private int spawnObstacle;
    public float forwardForce = 2000f; //how fast the player moves forward

    void Start()
    {
        //obstacle.transform.rotation = obstacleTransf.rotation;

        spawnObstacle = Random.Range(0, 3);
        //Debug.Log(Random.Range(0, 2));

        if (spawnObstacle == 0 || spawnObstacle == 1)
        {
            obstacle.SetActive(false);
        }
        else
        {
            //ObstacleCpuntCheck.obstacle
        };
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
