using UnityEngine;

public class SecretEnd : MonoBehaviour
{
	//
	// SORT OF UNUSED SCRIPT, Meant for secret end, currently it just displays a message in the console.
	//
	
    public GameManager gameManager; //Gamemanager sciprt/object

    public void OnTriggerEnter()
    {
        gameManager.SecretEnd();
    }

}
