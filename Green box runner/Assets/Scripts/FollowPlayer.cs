using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	//Used for the camera
	
    public Transform player;	//Player's transform component
    public Vector3 offset;		//Camera offset

    void Update()
    {
        transform.position = player.position + offset;
    }
}
