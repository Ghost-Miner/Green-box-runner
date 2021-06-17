using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CobeControl movement; // Player movement script

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
