using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public Manager goalmanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision == ball)
        {
            if (isRight)
            {
                goalmanager.addrightscore(1);
            }
            else
            {
                goalmanager.addleftscore(1);
            }
        }
    }
}
