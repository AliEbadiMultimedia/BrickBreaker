using System;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health;
    public SpriteRenderer SpriteRenderer;


    private void OnCollisionEnter2D(Collision2D other)
    {
        health--;
        if (health<=0)
        {
              gameObject.SetActive(false);  
              return;
        }

        UpdateSprite();
    }

    private void UpdateSprite()
    {
        SpriteRenderer.sprite= ViewService.instance.GetSprite(health);
    }
}