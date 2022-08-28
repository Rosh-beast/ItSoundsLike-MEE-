using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    public Image fadeEffect;
    public float timer;
    public bool isFadeOut = false;
    Color c;

    private void Start()
    {
        c = fadeEffect.color;
        c.a = 0;
    }

    private void Update()
    {
        RestartGame();
    }
    public void StartFadeIn()
    {
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
        for(float i = 0.05f; i<=1; i+=0.05f)
        {
            c.a = i;
            fadeEffect.color = c;
            yield return new WaitForSeconds(1);
        }
        isFadeOut = true;
    }

    void RestartGame()
    {
        if(isFadeOut)
        {
            Debug.Log("true");
        }
    }
}
