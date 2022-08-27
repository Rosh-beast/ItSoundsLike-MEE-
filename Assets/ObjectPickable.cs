using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickable : MonoBehaviour
{
    public GameObject containor;
    GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gain"))
        {
            target = other.gameObject;
            Debug.Log(target);
            target.transform.SetParent(containor.transform);
            PickupObject();
        }
    }

     void PickupObject()
     {
        Debug.Log("2");

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("a");
        }

     }
}
