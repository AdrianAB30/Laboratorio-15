using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float speed = 2f;

    void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rbd.velocity = new Vector2(0, speed);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Limite")
        {
            Destroy(gameObject);
        }
    }
}
