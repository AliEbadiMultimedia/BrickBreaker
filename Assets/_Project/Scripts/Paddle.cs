using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;

    public float speed;
    public Vector2 direction;

    void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
    }

    private void FixedUpdate()
    {
        Rigidbody2D.AddForce(direction * speed);
    }

    public void StartState()
    {
        Rigidbody2D.position = new Vector2(0, Rigidbody2D.position.y);
        Rigidbody2D.velocity = Vector2.zero;
    }
}