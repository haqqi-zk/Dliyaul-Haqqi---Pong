using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int rightscore;
    public int leftscore;
    public int maxscore;
    public BallController ball;

    public void addrightscore(int increment)
    {
        rightscore += increment;
        ball.ResetBall();
        if (rightscore >= maxscore)
        {
            GameOver();
        }
    }

    public void addleftscore(int increment)
    {
        leftscore += increment;
        ball.ResetBall();
        if (leftscore >= maxscore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
