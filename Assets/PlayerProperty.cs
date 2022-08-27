using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperty : MonoBehaviour
{
    [SerializeField] Transform holdArea;
    [SerializeField] float pickupRange;

    GameObject target;
    Rigidbody targetRB;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("pick");
            if (target == null)
            {
                Debug.Log("pick1");
                RaycastHit hit;
               if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    Debug.Log("pick2");
                    if (hit.transform.tag == "Gain")
                    {
                        Debug.Log("pick3");
                        Pickup(hit.transform.gameObject);
                    }
                    
                }
            }

        }
    }

    void Pickup(GameObject heldObj)
    {
         if(heldObj.GetComponent<Rigidbody>())
         {
             targetRB = heldObj.GetComponent<Rigidbody>();
             targetRB.useGravity = false;
             targetRB.constraints = RigidbodyConstraints.FreezeRotation;

             targetRB.transform.parent = holdArea;
             target = heldObj; 
         }

    }

  
}
