﻿using UnityEngine;
using System.Collections;

public class unitCreate : MonoBehaviour {
	public GameObject unit;
	public GameObject spawn;
	private float timeLeft = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {

		}
	}

	void OnMouseDown(){
		if (timeLeft > 0)
			return;
		timeLeft = 5;
		var e = (GameObject)Instantiate (unit, spawn.transform.position, transform.rotation);
		e.GetComponent<Transform>().parent = GameObject.Find("Canvas").transform;
		GameObject canvas = GameObject.Find("Canvas");
		e.transform.parent = canvas.transform;
	}
}
