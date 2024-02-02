using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_coin : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
        //spriteRenderer =  GetComponent<SpriteRenderer>();
        // spriteRenderer.color = Color.red;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       
    }
}
