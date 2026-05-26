using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    public Highscore hs;
    public LetterManager letterManager;
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void lvl1()
    {
        SceneManager.LoadScene("Lvl 1");
    }

    public void lvl2()
    {
        if(LetterManager.Instance.letterCount >= 1)
            SceneManager.LoadScene("Lvl 2");
    }

    public void lvl3()
    {
        if (LetterManager.Instance.letterCount >= 2)
            SceneManager.LoadScene("Lvl 3");
    }

    public void survival()
    {
        if (LetterManager.Instance.letterCount >= 2)
        { 
            SceneManager.LoadScene("Survival");
        }
    }
    public void quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
