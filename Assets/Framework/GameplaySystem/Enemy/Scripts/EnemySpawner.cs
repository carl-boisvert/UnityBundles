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
        private SpawnPointController[] spawnPoints;
        private BoxCollider trigger;

		private void Start()
		{
            trigger = GetComponent<BoxCollider>();
		}

        void SpawnEnemy(SpawnPointController spawn)
        {
            for (int i = 0; i < spawn.MaxNumberOfCreature; i++)
            {
                int indexEnemy = Random.Range(0, enemyPool.Length);
                Debug.Log("Spawning: " + enemyPool[indexEnemy].Name);
                EnemyController enemyCtrl = enemyPrefabs.GetComponent<EnemyController>();
                enemyCtrl.Enemy = enemyPool[indexEnemy];
                Instantiate(enemyPrefabs, spawn.transform);
                spawn.CurrentNumberOfCreature++;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Enter");
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