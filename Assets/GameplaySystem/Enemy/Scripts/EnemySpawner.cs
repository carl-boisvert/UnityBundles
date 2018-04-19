using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snappydue.UnityBundle
{
    public class EnemySpawner : MonoBehaviour
    {

        [SerializeField]
        private GameObject enemyPrefabs;
        [SerializeField]
        private Enemy[] enemyPool;
        [SerializeField]
        private GameObject[] spawnPoints;

        void SpawnEnemy()
        {
            int index = Random.Range(0, spawnPoints.Length);
            int indexEnemy = Random.Range(0, enemyPool.Length);
            Debug.Log("Spawning: " + enemyPool[indexEnemy].Name);
            EnemyController enemyCtrl = enemyPrefabs.GetComponent<EnemyController>();
            enemyCtrl.Enemy = enemyPool[indexEnemy];
            Instantiate(enemyPrefabs, spawnPoints[index].transform);
        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Enter");
            for (int i = 0; i <= spawnPoints.Length - 1; i++)
            {
                SpawnEnemy();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(this.transform.position, this.transform.localScale);
        }
    }
}