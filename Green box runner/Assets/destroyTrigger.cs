using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTrigger : MonoBehaviour
{
    public GameObject obstacleSpawn;
    public Transform ObstacleTransform;

    public GameObject obstacleParent;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "SecretEnd")
        {
            //Destroy(other.gameObject);
            Destroy(obstacleParent);

            //ObstacleTransform.position = new Vector3(0f, 0.65f, 0f);
            //Invoke("SpawnObject", 0.5f);
            SpawnObject();
        }
        if (other.transform.tag == "Obstacle")
        { 
            Destroy(obstacleParent);
        }
    }

    void SpawnObject()
    {
        Instantiate(obstacleSpawn, obstacleSpawn.transform.position = new Vector3(0f, 0.65f, 0f), ObstacleTransform.rotation);
        //Instantiate(obstacleSpawn, obstacleSpawn.transform.position = new Vector3(0f, 0.65f, -10f), ObstacleTransform.rotation);
    }
}
