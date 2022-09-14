using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPowerController : MonoBehaviour
{
    public Collider2D ball;
    public float countdown;
    public float buffDuration;
    public PowerUpController manager;
    public PaddleController paddle1;
    public PaddleController paddle2;

    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission = ball)
        {
            //increase paddle speed
            paddle1.IncreaseSpeed();
            paddle2.IncreaseSpeed();
            manager.RemovePowerUp(gameObject);
            //timer buff
            FunctionTimer.Create(paddle1.ReturnSpeed, buffDuration);
            FunctionTimer.Create(paddle2.ReturnSpeed, buffDuration);
        }
    }
    private void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        else
        {
            manager.RemovePowerUp(gameObject);
        }
    }

}
