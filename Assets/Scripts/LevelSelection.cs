using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public void FirstBegin()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Episode1");
    }

    public void SecondBegin()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Episode6");
    }
}
