﻿using UnityEngine;
using System.Collections;

public class unit : MonoBehaviour {

	private int health = 100;
	private float speed = 0.08f;
	private bool move = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "monster1") {
			return;
		}
		var pos = transform.position;
		if(move)
			pos.x += speed;
		else
			pos.x += 0;
		transform.position = pos;

		if (pos.x > 12.2f) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			Debug.Log("enemy hit!");
			move = false;

		}
		else if (coll.gameObject.tag == "unit") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			move = false;
		}
			

	}
}
