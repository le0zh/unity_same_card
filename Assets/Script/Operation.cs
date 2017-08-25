using UnityEngine;
using System.Collections;

public class Operation : MonoBehaviour
{
    private GameManagerBehavior gameManager;

    void Start()
    {
         gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

    public void OnYes()
    {
        gameManager.Score++;
    }

    public void OnNo()
    {
        gameManager.Score--;
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Menu");

        // reset
        gameManager.Score = 0;
        gameManager.CountDown = 30;
    }
}