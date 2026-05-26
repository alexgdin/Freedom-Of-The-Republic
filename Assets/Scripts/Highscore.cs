using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{
    private int time = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI highscore;
    float elapsedTime;
    public void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            highscore.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            highscore.text = "No Personal Best Yet";
        }
    }

    public void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StopTimer()
    {
        CancelInvoke();
        if (PlayerPrefs.GetInt("Highscore") > time)
        {
            SetHighscore();
        }
    }

    public void SetHighscore()
    {
        PlayerPrefs.SetString("Highscore", "timerText");
        highscore.text = PlayerPrefs.GetString("Highscore").ToString();
    }
}