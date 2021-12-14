using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    
    public static int lives;
    public int startLives = 10;

    public static int money;
    public int startMoney = 50;
    public static int score;
    public int startScore = 0;


    void Start()
    {
        lives = startLives;
        money = startMoney;
        score = startScore;
    }

}
