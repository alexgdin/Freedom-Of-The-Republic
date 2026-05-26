using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI highscore;

    public int scor;
    private int highscr;
    public void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            highscr = PlayerPrefs.GetInt("Highscore");
            highscore.text = "Best Score: " + highscr;
        }
        else
        {
            highscore.text = "No Highscore Yet";
        }
        scor = 0;
    }
    public void ScoreInc()
    {
        scor++;
        score.text = "Score: " + scor;

        if (scor > highscr)
        {
            highscr = scor;
            highscore.text = "NEW Highscore: " + highscr + "\nYOU HAVE THE FREEDOM!";

            PlayerPrefs.SetInt("Highscore", highscr);
            PlayerPrefs.Save();
        }
    }

}
