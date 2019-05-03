using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float targetTime = 30f;
    public bool gameEnd = false;

    Dropdown drop;
    int dropValue;

    public Transform countTime;

    public void TimeUp()
    {
        SceneManager.LoadScene(2);
    }

    void Update()
    {
        drop = GetComponent<Dropdown>();

        dropValue = drop.value;

        targetTime -= Time.deltaTime;
        countTime.GetComponent<TextMesh>().text = "Time left: " + targetTime;

        if (targetTime <= 0.0f)
        {
            gameEnd = true;
        }

        if (gameEnd == true)
        {
            TimeUp();
        }

    }
}
