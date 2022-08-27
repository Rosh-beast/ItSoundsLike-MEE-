using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperty : MonoBehaviour
{
    public bool isAParent = false;
    public GameObject[] targets;

    private void Start()
    {
       // target = 
    }
    private void Update()
    {
        if(isAParent)
        {
            foreach (GameObject target in targets)
            {
                target.transform.SetParent(this.transform);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Gain"))
        {
            isAParent = true;
        }
    }
}
