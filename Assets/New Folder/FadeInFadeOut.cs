using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    public Image fadeEffect;
    public float timer;
    Color c;

    private void Start()
    {
        c = fadeEffect.color;
        c.a = 0f;
    }

    IEnumerator FadeIn()
    {
        for(float i = 0.05f; i<=1; i+=0.05f)
        {
            c.a = i;
            fadeEffect.color = c;
            yield return new WaitForSeconds(timer);
        }
    }

    public void StartFadeIn()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeOut()
    {
        if(c.a == 1)
        {
            for (float i = 0.05f; i < 0; i -= 0.05f)
            {
                c.a = i;
                fadeEffect.color = c;
                yield return new WaitForSeconds(timer);
            }
        }
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

}
