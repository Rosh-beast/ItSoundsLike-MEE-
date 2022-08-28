using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameStartSceneTT : MonoBehaviour
{
    public float firstTTtime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Courotine());
    }
    IEnumerator Courotine()
    {
        yield return new WaitForSeconds(firstTTtime);
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Time.timeScale = 1;
        }
    }
}
