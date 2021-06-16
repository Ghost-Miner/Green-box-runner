using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private Rigidbody obstacleRB;

    public float forwardForce = 2000f; //how fast the player moves forward

    private void FixedUpdate()
    {
        obstacleRB.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
