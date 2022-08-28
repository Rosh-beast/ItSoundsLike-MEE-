using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    public float health;
    public FadeInFadeOut fadeEffector;
    public float timer = 1f;
    public Image[] heart;

    void Start()
    {
        health = 3f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("collided");
            DeductHealth();
        }
    }

    public void DeductHealth()
    {
        health--;

        if(health == 2)
        {
            Destroy(heart[2]);
        }

        else if(health == 1)
        {
            Destroy(heart[1]);
        }

        else if (health == 0)
        {
            Destroy(heart[0]);
            Destroy(gameObject);
            StartCoroutine(ScreenFade());

        }
    }

    IEnumerator ScreenFade()
    {
        fadeEffector.StartFadeIn();
        fadeEffector.StartFadeOut();
        yield return new WaitForSeconds(1);
    }

}
