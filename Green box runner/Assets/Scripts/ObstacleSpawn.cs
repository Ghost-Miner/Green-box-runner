using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;	//The obstacle object
    [SerializeField] private Rigidbody obstacleRB;	//UNUSED, rigidbody of obstacle object , UNUSED

    public Transform obstacleTransf;				//obstacle transform component, UNUSED

    public float roation;							//UNUSED

    private int spawnObstacle;						//Used for random generator
    public float forwardForce = 2000f; 				//UNUSED
	
    void Start()
    {
        //obstacle.transform.rotation = obstacleTransf.rotation; 
	
		//RANDOM GENERATOR - Current change for obstacle spawning: 33%
		//0 & 1 = disable obstacle
		//2 	= keep obstacle enabled
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
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
