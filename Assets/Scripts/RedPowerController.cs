using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerController : MonoBehaviour
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
            //increase paddle length
            paddle1.IncreaseLength();
            paddle2.IncreaseLength();
            manager.RemovePowerUp(gameObject);
            //timer buff
            FunctionTimer.Create(paddle1.ReturnScale, buffDuration);
            FunctionTimer.Create(paddle2.ReturnScale, buffDuration);
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
