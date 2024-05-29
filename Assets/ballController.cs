using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float speed;

    void Start()
    {
        restart();
    }

    public void restart()
    {
        transform.position= Vector3.zero;

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rgb.velocity = new Vector2(x * speed, y * speed);
    }
   
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeadZone")
        {
            if (collision.gameObject.name == "wallR")
                gameManager.main.PlayerLscore++;
            else if (collision.gameObject.name == "wallL")
                gameManager.main.PlayerRscore++;
            print("Game Over");
            gameManager.main.restartGame(); 

        }
        
    }
}
