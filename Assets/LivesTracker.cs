using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;


public class LivesTracker : MonoBehaviour
{
    public static int lives = 9;
    public Text LivesRemaining;

    public void DecreaseLives()
    {
        lives -= 1;
        LivesRemaining.text = lives.ToString();
        Debug.Log(lives);
        PlayerPrefs.SetInt("HighScoreName", lives);
    }
    public void IncreaseLives()
    {
        lives += 1;
        LivesRemaining.text = lives.ToString();
        Debug.Log(lives);
        PlayerPrefs.SetInt("HighScoreName", lives);
    }

    private void Start()
    {
        LivesRemaining.text = PlayerPrefs.GetInt("HighScoreName", 0).ToString();
    }

}
