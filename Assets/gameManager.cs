using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Transform PlayerL;
    public Transform PlayerR;
    public Transform Ball;

    public int PlayerLscore;
    public int PlayerRscore;

    public Text scoreL;
    public Text scoreR;
    

    public static gameManager main;

    private void Awake()
    {
        main = this;
    }

    private void Update()
    {
        scoreL.text=PlayerLscore.ToString();
        scoreR.text=PlayerRscore.ToString();
    }

    public void restartGame()
    {
        PlayerL.position = new Vector3(PlayerL.position.x, 0, 0);
        PlayerR.position = new Vector3(PlayerR.position.x, 0, 0);

        Ball.GetComponent<ballController>().restart();
    }
}
