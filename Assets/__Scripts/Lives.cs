using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    static public int Life = 3;
    void Awake()
    {                                                           // a
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("Lives"))
        {                               // b
            Life = PlayerPrefs.GetInt("Lives");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("Lives", Life);                              // c
    }
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Lives: " + Life;

        PlayerPrefs.SetInt("Lives", Life);

        // Update the PlayerPrefs HighScore if necessary
        if (Life == 0)
        {                       
            PlayerPrefs.SetInt("Lives", 3);
            SceneManager.LoadScene("MainMenu");

        }
    }

}
