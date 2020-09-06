using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour {

	public GameObject Cell;
	float NextCell = 0;
	float CellInterval = 0.2f;  //A new pellet every so often.

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > NextCell) {
			Vector3 pos = transform.position;  //Set based on current position of the CellManager (set via Unity).
			pos.x += Random.Range(-20, 20);
			pos.z += Random.Range(-20, 20);

			Instantiate (Cell, pos, Quaternion.identity);
			//Instantiate (Cell, new Vector3 (0, 5, 0), Quaternion.identity);  //Volcanic at the origin.
			NextCell = Time.time + CellInterval;
		}
	}
}
