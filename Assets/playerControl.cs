using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public bool isPlayerL;
    public Rigidbody2D rgb;
    public float speed;

    void Start()
    {
        
    }    

    void Update()
    {
        if (isPlayerL)
        {
            rgb.velocity = Vector2.up * Input.GetAxisRaw("Vertical") * speed;
        }
        else
        {
            rgb.velocity = Vector2.up * Input.GetAxisRaw("Vertical2") * speed;
        }
    }
}
