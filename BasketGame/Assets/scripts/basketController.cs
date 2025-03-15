using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketController : MonoBehaviour
{
    int speed = 1;
    float leftBoundary = -1.19f;
    float rightBoundary = 1.19f;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftBoundary)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < rightBoundary)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
