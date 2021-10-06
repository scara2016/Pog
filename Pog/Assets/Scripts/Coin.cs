using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{    
    private ScoreKeeper scorekeeper;
    // Start is called before the first frame update
    void Start()
    {
        scorekeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider c)
    {
        Destroy(gameObject);
        scorekeeper.UpdateScore();
        if (c.gameObject.CompareTag("Player1"))
        {
           scorekeeper.UpdateScore(1);
        }

        if (c.gameObject.CompareTag("Player2"))
        {
           scorekeeper.UpdateScore(2);
        }
    }


}
