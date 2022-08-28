using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostCollector : MonoBehaviour
{
    public GameObject[] ghosts;
    public int counter = 0;
    public GhostLoader Loader;
    public Canvas tutorialCanvas;
    public Canvas mainCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (counter < ghosts.Length)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Ghost"))
            {
                Destroy(other.gameObject);
                PickGhost();
                counter++;
            }
        }
    }
    public void PickGhost()
    {
       ghosts[counter].SetActive(true);

        if(ghosts[0])
        {
            Time.timeScale = 0;
            Debug.Log("canvas activated");
            tutorialCanvas.gameObject.SetActive(true);
            mainCanvas.gameObject.SetActive(false);

            if (Input.GetKeyDown("escape"))
            {
                Time.timeScale = 1;
            }
        }
        else
        {
            mainCanvas.gameObject.SetActive(true); ;

        }
    }

}
