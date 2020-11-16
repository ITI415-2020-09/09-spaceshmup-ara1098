using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNewScene : MonoBehaviour
{

    public void LoadEasy()
    {
        SceneManager.LoadScene("Easy");

    }
    public void LoadIntermediate()
    {
        SceneManager.LoadScene("Intermediate");

    }

    public void LoadExpert()
    {
        SceneManager.LoadScene("Expert");

    }


}
