using UnityEngine;

public class CobeControl : MonoBehaviour
{
    public Rigidbody rb; 				//Rigidbody component
    public Transform transf;            //Transform component
    public float forwardForce = 2000f; 	//how fast the player moves forward
    public float sidewaysForce = 500f;  //how fast the player moves sideways
    public float sidewaysSnap = 15f;

    public Transform player2Tranf;		//Player duplicate, used for resetting rotation

    private void Start()
    {
        rb.transform.rotation = player2Tranf.rotation;
        transf.position = new Vector3(0f, 0.6f, 0f);
    }

    void FixedUpdate()
    {
        // CONTROLS

        if (PauseMenu.IsPaused == false && Tutorial.TutorialClosed == true)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            /*if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }*/

            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                transf.position = transform.position + new Vector3(sidewaysSnap * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                transf.position = transform.position - new Vector3(sidewaysSnap * Time.deltaTime, 0f, 0f);
            }

            if (rb.position.y < 0.3f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
	
    void Update()
    {
		//RESTART LEVEL
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<GameManager>().Restart();
            Time.timeScale = 1;
        }
    }
}
