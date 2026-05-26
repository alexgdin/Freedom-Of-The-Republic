using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Windows;
using System.Threading;
using Unity.VisualScripting;

public class PlayerAttack : MonoBehaviour
{
    private float timr = 2;
    private float cooldowntimr = 1;
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    
    void Update()
    {
        if( UnityEngine.Input.GetMouseButtonDown(0) && timr > cooldowntimr)
            {
            timr = 0;
            SpawnEnemy();
            }
        timr += Time.deltaTime;
    }
    void SpawnEnemy()
    {
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
