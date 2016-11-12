using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public GameObject background;
	public GameObject maincamera;
	public GameObject unit;
	public GameObject spawn;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		//Debug.Log (background.transform.localPosition.x);

		//var pos = background.transform.position;
		var pos = maincamera.transform.position;

		if (x < 0) {
			pos.x -= 0.2f;
		}
		else if (x < 15) {
			pos.x -= 0.15f;
		}
		else if (x < 30) {
			pos.x -= 0.12f;
		}
		else if (x < 50) {
			pos.x -= 0.08f;
		}
		else if (x < 60) {
			pos.x -= 0.07f;
		}
		else if (x < 70) {
			pos.x -= 0.06f;
		}
		else if (x < 80) {
			pos.x -= 0.05f;
		}
		else if (x > 640) {
			pos.x += 0.2f;
		}
		else if (x > 635) {
			pos.x += 0.15f;
		}
		else if (x > 620) {
			pos.x += 0.12f;
		}
		else if (x > 590) {
			pos.x += 0.08f;
		}
		else if (x > 580) {
			pos.x += 0.07f;
		}
		else if (x > 570) {
			pos.x += 0.06f;
		}
		else if (x > 560) {
			pos.x += 0.05f;
		}

		if (pos.x > 4.9f) {
			pos.x = 4.9f;
		}
		else if (pos.x < -0.17f) {
			pos.x = -0.17f;
		}

		maincamera.transform.position = pos;
			
		Debug.Log ("Mouse x = " + pos.x + "  Mouse y = " + pos.y);
	}


	void OnMouseDown(){
		Instantiate(unit, spawn.transform.position, transform.rotation);
	}

}
