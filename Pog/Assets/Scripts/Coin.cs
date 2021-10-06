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

    void OnTriggerEnter(Collider collider)
    {

        Move player = collider.GetComponent<Move>();
        if (player != null)
        {
            Destroy(gameObject);
            scorekeeper.UpdateScore();
        }
    }
}
