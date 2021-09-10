using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster // va hériter de toutes les capacités de la classe Monster
{

    public Vector2 speed = Vector2.zero;
    private SpriteRenderer spriteRenderer;

    public float hitRange = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    virtual protected void Update()
    {

        Vector2 start;
        // float factor = 1f;
        Vector2 direction;

        // orientation de l'image
        if(speed.x > 0)
        {
            spriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            // factor = -1f;
            direction = Vector2.right;
        }
        else { spriteRenderer.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            // factor = 1f;
            direction = Vector2.left;
             }

        Debug.DrawRay(start, direction * hitRange, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if(hit.collider != null)
        {
            speed.x *= -1;
        }

        // Debug.DrawRay((Vector2)transform.position + Vector2.right *0.5f, Vector2.right *100, Color.red);
        // RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position + Vector2.right *0.5f, Vector2.right);
        //if(hit.collider != null)
        //{
        //print(hit.collider.name);
        //}


        // déplacement
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement; // casting du deplacement --> caster le deplacement en Vector3
    }
}
