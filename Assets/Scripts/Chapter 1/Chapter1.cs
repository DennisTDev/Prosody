﻿using UnityEngine;
using System.Collections;
public class Chapter1 : MonoBehaviour {
	public Transform player;
	public CloudCluster cloudCluster;
	public EyeShutter eyes;
	public GameObject narration;
	public GameObject track;
	void Start () {
		for (int i = 1; i <= 200; i++) {
			int count = 15;
			Vector3 position = new Vector3(0, i * -200, 0);
			int radius = 500;
			int deltaY = 100;
			cloudCluster.Spawn(count, position, radius, deltaY);
		}
		StartCoroutine("Go");
	}

	IEnumerator Go() {
		yield return new WaitForSeconds(3);
		narration.SetActive(true);
		yield return new WaitForSeconds(16);
		eyes.Open();
		yield return new WaitForSeconds(40);
		eyes.Close();
		yield return new WaitForSeconds(3);
		Application.LoadLevel("Chapter 2");
	}

	
}
