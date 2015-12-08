using UnityEngine;
using System.Collections;

public class DuckSpawning : MonoBehaviour {

	public GameObject Duck;
	public float spawnTime = 6f;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnDuck", spawnTime, spawnTime);
	}

	void SpawnDuck()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (Duck, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
