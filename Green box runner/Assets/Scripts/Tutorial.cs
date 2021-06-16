using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public static bool TutorialClosed = false;
    public GameObject TutorialUI;

    private void Start()
    {
        if (TutorialClosed == true)
        {
            TutorialUI.SetActive(false);
        }
        else
        {
            TutorialUI.SetActive(true);
        }
    }
    void Update()
    {
        if (TutorialClosed == false)
        {
            if (Input.GetKeyDown("d") || Input.GetKeyDown("a"))
            {
                TutorialClosed = true;
                TutorialUI.SetActive(false);
            }
        }
    }
}
