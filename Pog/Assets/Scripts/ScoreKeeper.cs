using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int scorePlayer1;
    private int scorePlayer2;
    private UIManager uIManager;
    public int ScorePlayer1
    {
        get
        {
            return scorePlayer1;
        }
    }
    public int ScorePlayer2
    {
        get
        {
            return scorePlayer2;
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
    public void UpdateScore(int PlayerNumber)
    {
        if (PlayerNumber == 1)
        {
            scorePlayer1++;
            uIManager.UpdateScoreTextPlayer1(scorePlayer1);
        }
        if (PlayerNumber == 2)
        {
            scorePlayer2++;
            uIManager.UpdateScoreTextPlayer2(scorePlayer2);
        }
    }
}
