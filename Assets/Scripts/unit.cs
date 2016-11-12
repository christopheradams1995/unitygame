using UnityEngine;
using System.Collections;

public class unit : MonoBehaviour {

	private int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "monster1") {
			return;
		}
		var pos = transform.position;
		pos.x += 0.05f;
		transform.position = pos;

		if (pos.x > 12.2f) {
			Destroy (gameObject);
		}
	}
}
