using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCollector : MonoBehaviour
{
    public GameObject[] ghosts;
    public int counter = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (counter < ghosts.Length)
        {
            if (other.gameObject.tag == "MeGhost")
            {
                Destroy(other.gameObject);
                PickGhost();
                counter++;
            }
        }
    }
    void PickGhost()
    {
        ghosts[counter].SetActive(true);
        
            
    }

}
