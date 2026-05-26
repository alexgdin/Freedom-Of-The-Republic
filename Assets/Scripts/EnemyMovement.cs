using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}