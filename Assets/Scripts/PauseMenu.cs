using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool ispaused = false;
    public GameObject varpause;
    private Highscore hs;
    public GameObject pausedMenuUI;
    public GameObject deathscr;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void RestartDeath()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        deathscr.SetActive(false);
    }
    public void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0;
        ispaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1;
        ispaused = false;
        varpause.SetActive(true);
    }
}
