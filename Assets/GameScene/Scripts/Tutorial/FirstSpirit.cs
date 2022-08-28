using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSpirit : MonoBehaviour
{

    public GameObject spiritUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Time.timeScale = 1;
            spiritUI.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            spiritUI.SetActive(true);
        }
    }
}
