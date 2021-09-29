using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis(InputAxis.Horizontal);
        float Vertical = Input.GetAxis(InputAxis.Vertical);
        
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
}
