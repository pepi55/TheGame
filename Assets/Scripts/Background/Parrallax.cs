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
		pos.x -= 5f * Time.deltaTime;

		if (pos.x <= -16f) {
			pos.x = 16f;
		}

		transform.position = pos;
	}
}
