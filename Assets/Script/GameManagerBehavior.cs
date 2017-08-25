using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManagerBehavior : MonoBehaviour
{
    public Text scoreLabel;
    public Text timerLabel;

    /// <summary>
    /// 得分
    /// </summary>
    private int score;

    /// <summary>
    /// 得分
    /// </summary>
    public int Score
    {
        get { return score; }

        set
        {
            score = value;
            scoreLabel.text = "Score: " + score;
        }
    }

    /// <summary>
    /// 倒计时
    /// </summary>
    private float countDown;

    public float CountDown
    {
        get { return countDown; }

        set
        {
            countDown = value;
            timerLabel.text = string.Format("Time: 0:{0:00}", this.CountDown);
        }
    }

    void Update()
    {
        if (this.CountDown <= 0)
        {
            // Debug.Log("game over");
        }
        else
        {
            this.CountDown -= Time.deltaTime;
        }
    }

    void Start()
    {
        this.Score = 0;
        this.CountDown = 30;
    }
}
