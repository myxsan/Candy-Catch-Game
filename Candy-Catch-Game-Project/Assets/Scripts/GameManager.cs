using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject livesHolder;
    
    [SerializeField] Text scoreText;

    private int score = 0;
    private int lives = 3;
    private bool gameOver = false;

    private void Awake() {
        instance = this;
    }
    
    void Start()
    {
        score = 0;
        PrintScore();
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            PrintScore();
        }
    }

    private void PrintScore()
    {
        scoreText.text = score.ToString("00");
    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    private void GameOver()
    {
        CandySpawner.instance.StopSpawning();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
    }
}
