using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snappydue.UnityBundle
{
    public class EnemySpawner : MonoBehaviour
    {

        [SerializeField]
        private GameObject enemyPrefab;
        [SerializeField]
        private Enemy[] enemyPool;
        private SpawnPointController[] spawnPoints;
        private BoxCollider trigger;

		private void Start()
		{
            trigger = GetComponent<BoxCollider>();
            spawnPoints = GetComponentsInChildren<SpawnPointController>();
		}

        void SpawnEnemy(SpawnPointController spawn)
        {
            for (int i = 0; i < spawn.MaxNumberOfCreature; i++)
            {
                int indexEnemy = Random.Range(0, enemyPool.Length);
                EnemyController enemyCtrl = enemyPrefab.GetComponent<EnemyController>();
                enemyCtrl.Enemy = enemyPool[indexEnemy];
                GameObject enemy = Instantiate(enemyPrefab, spawn.transform);
                enemy.GetComponent<EnemyController>().SpawnPoint = spawn;
                spawn.CurrentNumberOfCreature++;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            for (int i = 0; i <= spawnPoints.Length - 1; i++)
            {
                if(spawnPoints[i].HasPlaceAvaillable())
                {
                    SpawnEnemy(spawnPoints[i]);
                }
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(this.transform.position, trigger.transform.localScale);
        }
    }
}