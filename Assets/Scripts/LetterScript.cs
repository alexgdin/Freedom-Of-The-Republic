using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LetterScript : MonoBehaviour
{
    public LetterManager letterManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Destroy(gameObject);
                FindAnyObjectByType<LetterManager>().letterCount++;
                PlayerPrefs.SetInt("Letter Mannager", FindAnyObjectByType<LetterManager>().letterCount);
                PlayerPrefs.Save();
            }
    }
}
