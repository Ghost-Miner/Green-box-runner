using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	//
	// UNUSED SCRIPT - Used for testing obstacle moving instead of player - Used in "tests" scene
	//
	
    [SerializeField] private Rigidbody obstacleRB; // Obstacle rigidbody

    public float forwardForce = 2000f; //how fast the player moves forward

    private void FixedUpdate()
    {
        obstacleRB.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
