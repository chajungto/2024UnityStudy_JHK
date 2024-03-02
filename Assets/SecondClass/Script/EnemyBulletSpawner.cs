using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletTransform;
    public float spawnTime = 3f;

    void Start()
    {
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet()
    {
        while (true)
        {
            GameObject enemyBullet =
                Instantiate(bullet, bulletTransform.position,Quaternion.identity); 

            EnemyBullet bulletControl = enemyBullet.GetComponent<EnemyBullet>();
            bulletControl.Test();

            yield return new WaitForSeconds(spawnTime);
        }
    }

}
