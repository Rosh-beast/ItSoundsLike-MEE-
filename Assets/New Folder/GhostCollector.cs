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
            if (other.gameObject.layer == LayerMask.NameToLayer("Ghost"))
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
        Debug.Log("Ghost");
            
        if(counter == ghosts.Length-1)
        {
            GameObject other = GameObject.FindGameObjectWithTag("MeGhost");
            other.GetComponent<SphereCollider>().radius = 5;
            other.GetComponent<MeshRenderer>().material.color = Color.red;
        
        }
    }

}
