using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    private UIManager uIManager;
    public int Score
    {
        get
        {
            return score;
        }
    }
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score++;
        uIManager.UpdateScoreText(score);
    }
}
