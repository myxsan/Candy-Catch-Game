using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private int score = 0;
    private bool gameOver = false;

    private void Awake() {
        instance = this;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        print(score);
    }
}
