using UnityEngine;

public class SecretEnd : MonoBehaviour
{

    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.SecretEnd();
    }

}
