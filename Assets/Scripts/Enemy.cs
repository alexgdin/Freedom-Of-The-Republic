using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public CapsuleCollider2D capsuleCollider2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {   
            Destroy(gameObject);
            FindAnyObjectByType<Score>().ScoreInc();
            FindAnyObjectByType<Spawner>().spawnInterval -= 0.1f;
            FindAnyObjectByType<EnemyFollow>().speed += 0.1f;
        }
    }

}