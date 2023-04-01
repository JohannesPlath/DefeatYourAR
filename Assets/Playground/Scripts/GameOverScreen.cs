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
    [SerializeField] private GameObject welcomeScreen;
    [SerializeField] private GameObject XROrigin;
    public void Setup(int score)
    {
        if (gameObject != null) gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Killed Zobies";
    }

    public void RestartButton()
    {
        Instantiate(XROrigin);
        Instantiate(welcomeScreen);
        SceneManager.LoadScene("ZombieAttak");
    }

    /*public void ExitButton()
    {
        SceneManager. LoadScene("Quit");
    }*/
}