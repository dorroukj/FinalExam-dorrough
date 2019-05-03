using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class TextFile : MonoBehaviour
{
    static void WriteScore()
    {
        string path = "Assets/Resources/scores.txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Computer");
        writer.Close();

        AssetDatabase.ImportAsset(path);
        //TextAsset asset = Resources.Load("200");

    }

    static void ReadString()
    {
        string path = "Assets/Resources/scores.txt";
        StreamReader reader = new StreamReader(path);

        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
