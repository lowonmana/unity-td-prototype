
using UnityEngine;
using System.Collections;

class EnemySpawner : MonoBehaviour
{
	public GameObject enemyPrefab;
	public GameObject king;

	private void Start()
	{
		InvokeRepeating( "SpawnEnemy" , 0.0f , 2.0f );
	}

	private void SpawnEnemy()
	{
		float offSet     = Random.Range( 5.0f , 13.0f );
		Vector2 spawnPos = new Vector2( king.transform.position.x + offSet , king.transform.position.y + offSet );
		Instantiate( enemyPrefab , spawnPos , Quaternion.identity );
	}
}