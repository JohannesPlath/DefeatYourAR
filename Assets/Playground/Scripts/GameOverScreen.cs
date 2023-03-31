using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text pointsText;

    public void Setup(int score)
    {
        if (gameObject != null) gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Killed Zobies";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("ZombieAttak");
    }

    /*public void ExitButton()
    {
        SceneManager. LoadScene("Quit");
    }*/
}