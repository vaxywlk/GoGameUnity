using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kodepemain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public float panSpeed = 20f;

    int speed;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
    }
    
}
