using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int lives;
    public int startLives = 10;

    public static int money;
    public int startMoney = 50;

    void Start()
    {
        lives = startLives;
        money = startMoney;
    }
}
