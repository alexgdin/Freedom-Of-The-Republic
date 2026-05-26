using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

}
