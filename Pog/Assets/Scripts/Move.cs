using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3;
    private int player;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Player1"))
        {
            player = 1;
        }

        if (gameObject.CompareTag("Player2"))
        {
            player = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis(InputAxis.Horizontal);
        float Vertical = Input.GetAxis(InputAxis.Vertical);
        float horizontalPlayer2 = Input.GetAxis(InputAxis.horizontalPlayer2);
        float verticalPlayer2 = Input.GetAxis(InputAxis.verticalPlayer2);

        if (player == 1)
        {
          if (Vertical > 0)
          {
              transform.Translate(Vector3.forward * speed * Time.deltaTime);
          }
          if (Vertical < 0)
          {
              transform.Translate(Vector3.back * speed * Time.deltaTime);
          }
          if (Horizontal > 0)
          {
              transform.Translate(Vector3.right * speed * Time.deltaTime);
          }
          if (Horizontal < 0)
          {
             transform.Translate(Vector3.left * speed * Time.deltaTime);
          }
        } 
        else
        {
          if (verticalPlayer2 > 0)
          {
              transform.Translate(Vector3.forward * speed * Time.deltaTime);
          }
          if (verticalPlayer2 < 0)
          {
              transform.Translate(Vector3.back * speed * Time.deltaTime);
          }
          if (horizontalPlayer2 > 0)
          {
              transform.Translate(Vector3.right * speed * Time.deltaTime);
          }
          if (horizontalPlayer2 < 0)
          {
             transform.Translate(Vector3.left * speed * Time.deltaTime);
          }
        } 
    }
}
