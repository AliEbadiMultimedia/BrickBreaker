using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float speed;

    void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartTrajectory();
    }

    public void StartTrajectory()
    {
        Rigidbody2D.position=Vector2.zero;
        Rigidbody2D.velocity=Vector2.zero;
        Invoke(nameof(ResetBall),1);
    }

    public void ResetBall()
    {
        Vector2 direction=new Vector2();
        direction.y = -1;
        var randomX = Random.Range(-1, 1f);
        while (randomX==0)
        {
            randomX = Random.Range(-1, 1f);
        }
        direction.x = randomX;
        Rigidbody2D.velocity=direction.normalized*speed;
    }

    public float timeCoef=1;
    private void FixedUpdate()
    {
        timeCoef = Time.timeSinceLevelLoad / 100+1;
        Rigidbody2D.velocity = Rigidbody2D.velocity.normalized * speed*timeCoef;
    }
}