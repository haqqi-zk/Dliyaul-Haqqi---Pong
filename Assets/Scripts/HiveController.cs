using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUpController manager;
    public float countdown;

    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission == ball)
        {
            ball.GetComponent<BallController>().IncreaseSpeed(magnitude);
            manager.RemovePowerUp(gameObject);
            countdown = 0;
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
        Debug.Log(countdown);
    }
}
