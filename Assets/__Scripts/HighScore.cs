﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 0;

    void Awake()
    {                                                         
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore"))
        {                               // b
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);                              
    }


    public void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "" + score;

        if (score > PlayerPrefs.GetInt("HighScore"))
        {                      
            PlayerPrefs.SetInt("HighScore", score);

        }

    }
}
