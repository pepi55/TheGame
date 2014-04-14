using UnityEngine;
using System.Collections;

public class Parrallax : MonoBehaviour {
	private Vector2 pos;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		pos.x -= 0.1f;

		if (pos.x <= -16f) {
			pos.x = 16f;
		}

		transform.position = pos;
	}
}
