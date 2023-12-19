using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    public GameObject knifePrefab;
	public List<GameObject> targetPrefabs;

	public GameObject knifeSpawnPoint;
	public GameObject balloonSpawnSurface;

	public GameObject AllKnives;
	public GameObject AllTargets;

	private AudioSource _audioSource;

	private void Start()
	{
		_audioSource = GetComponent<AudioSource>();
	}
	// reset knives and spawn new targets
	public void ResetGame() {
		Destroy(AllKnives);
		foreach(Transform child in AllTargets.transform){
			Destroy(child.gameObject);
		}

		var newObj = Instantiate(knifePrefab, knifeSpawnPoint.transform.position, Quaternion.identity);
		AllKnives = newObj;

		System.Random random = new System.Random();
		for(int i = 0; i < 7; i++) {
            Vector3 balloonSpawnPoint = GetRandomSpawnPosition();
		
			int idx = random.Next(0, targetPrefabs.Count);
            Instantiate(targetPrefabs[idx], balloonSpawnPoint, Quaternion.identity, AllTargets.transform);
		}

		_audioSource.Play();
		GameEventManager.current.ResetGame();
	}

	private Vector3 GetRandomSpawnPosition() {
		Collider targetCollider = balloonSpawnSurface.GetComponent<Collider>();

		Bounds bounds = targetCollider.bounds;

		float rx = UnityEngine.Random.Range(bounds.min.x, bounds.max.x);
		float ry = UnityEngine.Random.Range(bounds.min.y, bounds.max.y);
		// float rz = Random.Range(bounds.min.z, bounds.max.z);
		float rz = bounds.min.z;

		return new Vector3(rx, ry, rz);
	}
}
