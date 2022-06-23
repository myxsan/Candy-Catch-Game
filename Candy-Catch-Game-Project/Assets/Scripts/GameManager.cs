using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    [SerializeField] Text scoreText;

    private int score = 0;
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
        score++;
        PrintScore();
    }

    private void PrintScore()
    {
        scoreText.text = score.ToString("00");
    }
}
