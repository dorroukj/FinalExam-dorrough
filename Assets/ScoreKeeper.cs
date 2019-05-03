using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class ScoreKeeper : MonoBehaviour
{

    
    static public int newScore = 0;
    public Text NewScore;

    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        PlayerPrefs.SetInt("HighScore", newScore);

        string path = "Assets/Resources/scores.txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(newScore);
        writer.Close();
    }

    public void DecreaseScore() // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        PlayerPrefs.SetInt("HighScore", newScore);

    }

    void Start()
    {
        
        NewScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    
}
