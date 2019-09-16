using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        // default invisible
        Color tmpColor = spriteRenderer.color;
        tmpColor.a = 0.0f;
        spriteRenderer.color = tmpColor;
    }

    public void FadeIn()
    {
        // decrease alpha
        Color tmpColor = spriteRenderer.color;
        tmpColor.a -= 0.1f;
        spriteRenderer.color = tmpColor;
    }

    public void FadeOut()
    {
        // increase alpha
        Color tmpColor = spriteRenderer.color;
        tmpColor.a += 0.1f;
        spriteRenderer.color = tmpColor;
    }
}
