﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "HIGH SCORE: " + score;

    }
}
