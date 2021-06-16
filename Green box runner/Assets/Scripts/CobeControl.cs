using UnityEngine;

public class CobeControl : MonoBehaviour
{
    public Rigidbody rb; //var for player object
    public float forwardForce = 2000f; //how fast the player moves forward
    public float sidewaysForce = 500f; //how fast the player moves sideways

    public Transform player2Tranf;

    private void Start()
    {
        rb.transform.rotation = player2Tranf.rotation;
    }

    void FixedUpdate()
    {
        if (PauseMenu.IsPaused == false && Tutorial.TutorialClosed == true)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            FindObjectOfType<GameManager>().Restart();
        }
    }
}
