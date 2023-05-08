using System;
using UnityEngine;

public class ResetZone : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        ball.StartTrajectory();
        paddle.StartState();
    }
}