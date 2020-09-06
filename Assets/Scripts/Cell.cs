using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	Rigidbody rb;
	Transform tr;
	float Born;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();  //lower case gameObject is the cellitself.
		tr = gameObject.GetComponent<Transform> ();
		rb.AddForce (new Vector3 (200, 0, 0));  //Shower going to the left.
		Born = Time.time;
	}

	// Update is called once per frame
	void Update () {
		//Instead of doing things to the transform, do things to rigidbody using force.
		if (tr.position.y < 1) {
			rb.AddForce (new Vector3 (0, 5, 0));  //Hover when getting to low part of landscape as if exploded.
		}

		float Age = Time.time - Born;
		transform.localScale = Vector3.one * (10 - Age) / 10.0f;  //Gets smaller over time.
		if (Age > 10) {
			Destroy (gameObject);  //Disappear after a while.
		}
	}
}
