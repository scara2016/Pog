using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   
    public Text scoreTextPlayer1;
    public Text scoreTextPlayer2;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
