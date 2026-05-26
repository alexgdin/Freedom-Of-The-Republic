using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathscreen;
    public Score sc;
    public bool isAlive = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Death();
        }
    }
    public void Death()
    {
    Time.timeScale = 0;
    gameObject.SetActive(false);
    deathscreen.SetActive(true);
    }
}
