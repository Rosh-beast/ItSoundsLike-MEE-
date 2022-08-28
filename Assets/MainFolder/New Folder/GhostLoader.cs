using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostLoader : MonoBehaviour
{
    public GameObject emptySlot;
    public GameObject fillslot;
    public GhostCollector collector;
    public bool isCollected = false;
    private void Start()
    {
        fillslot.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            SubmitGhost();
            Debug.Log("done");
        }
    }

    void SubmitGhost()
    {
        emptySlot.SetActive(false);
        fillslot.SetActive(true);

        for (int i = 0; i < collector.ghosts.Length; i++)
        {
            collector.ghosts[i].SetActive(false);
            collector.counter = 0;
        }
        isCollected = true;
    }






}
