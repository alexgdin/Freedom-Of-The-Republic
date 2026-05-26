using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class FallFromPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
