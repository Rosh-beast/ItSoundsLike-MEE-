using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameStartSceneTT : MonoBehaviour
{
    public float firstTTtime;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject Scene5;
    public GameObject Scene6;
    public GameObject Scene7;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Courotine());
        StartCoroutine(cour2());
        StartCoroutine(cour2pause());
    }

    IEnumerator Courotine()
    {
        yield return new WaitForSeconds(firstTTtime);
        Scene1.SetActive(true);
        
        Time.timeScale = 0;
    }
    IEnumerator cour2()
    {
        yield return new WaitForSeconds(5f);
        Scene2.SetActive(true);
    }
    IEnumerator cour2pause()
    {
        yield return new WaitForSeconds(9f);
        Scene2.SetActive(false);
    }
    IEnumerator cour4()
    {
        yield return new WaitForSeconds(5f);
        Scene4.SetActive(true);
    }
    IEnumerator cour5()
    {
        yield return new WaitForSeconds(5f);
        Scene5.SetActive(true);
    }
    IEnumerator cour6()
    {
        yield return new WaitForSeconds(5f);
        Scene6.SetActive(true);
    }
    IEnumerator cour7()
    {
        yield return new WaitForSeconds(5f);
        Scene7.SetActive(true);
    }
    // Update is called once per frame
    public void Update()
    {
        
        if (Input.GetKeyDown("escape"))
        {
            Time.timeScale = 1;
            Scene1.SetActive(false);
            
        }
    }
}
