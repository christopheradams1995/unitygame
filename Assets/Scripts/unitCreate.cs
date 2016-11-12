using UnityEngine;
using System.Collections;

public class unitCreate : MonoBehaviour {
	public GameObject unit;
	public GameObject spawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Instantiate(unit, spawn.transform.position, transform.rotation);
	}
}
