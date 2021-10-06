using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startingTimer = 3;
    private float timer = 3;
    private int direction;
    private int previousDirection;

    void Start()
    {
        direction = Random.Range(1, 5);    
    }

    // Update is called once per frame
    void Update()
    {
        // 1 = Forward, 2 = Right, 3 = Left, 4 = Back
        
        if(direction == 1)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (direction == 2)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (direction == 3)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (direction == 4)
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }

        timer -= Time.deltaTime;

        if(timer <= 0 || previousDirection == direction)
        {
            previousDirection = direction;
            direction = Random.Range(1, 5);
            timer = startingTimer;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        Move player = collider.GetComponent<Move>();
        if (player != null)
        {
            Destroy(player.gameObject);
            Destroy(gameObject);
        }
    }
}
