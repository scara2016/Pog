using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScoreText(int score)
    {
        ScoreText.text = "Score:- " + score;
    }
}
