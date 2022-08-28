using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    public Image fadeEffect;
    public float timer;
    Color c;
   public float alpha;

    private void Start()
    {
        c = fadeEffect.color;
        alpha = c.a;
    }

    IEnumerator FadeIn()
    {
        for(float i = 0.05f; i<=1; i+=0.05f)
        {
            c.a = i;
            fadeEffect.color = c;
            yield return new WaitForSeconds(1);
        }
        alpha = 1f;
    }

    public void StartFadeIn()
    {
        StartCoroutine(FadeIn());
    }
    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        if (alpha == 1f)
        {
            for (float i = 1; i >= -0.05f; i -= 0.05f)
            {
                c.a = i;
                fadeEffect.color = c;
                yield return new WaitForSeconds(1);
            }
        }
    }

    

}
