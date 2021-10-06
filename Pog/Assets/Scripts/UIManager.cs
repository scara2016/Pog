using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text[] scoreTexts;
    private Text scoreTextPlayer1;
    private Text scoreTextPlayer2;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreTexts = GetComponents<Text>();
        scoreTextPlayer1 = scoreTexts[0];
        scoreTextPlayer2 = scoreTexts[1];
    }

    public void UpdateScoreTextPlayer1(int score)
    {
        scoreTextPlayer1.text = "Score:- " + score;
    }
    public void UpdateScoreTextPlayer2(int score)
    {
        scoreTextPlayer2.text = "Score:- " + score;
    }
}
