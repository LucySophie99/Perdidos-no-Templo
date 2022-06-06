using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tridente : MonoBehaviour
{
    float moveSpeed = 50f;
    Rigidbody2D rb;
    public Transform target;
    Vector2 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy(gameObject, 30f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals ("selectedSkin"))
        {
            healthBarNeptuno.health -= 1f;
            Destroy (gameObject);
        }
    }
}
