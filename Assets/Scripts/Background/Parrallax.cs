using UnityEngine;
using System.Collections;

public class Parrallax : MonoBehaviour {
	private Vector2 pos;

	void Start () {
		pos = transform.position;
	}

	void OnEnable () {
		GameController.ScrollScreen += Scroll;
	}

	void OnDisable () {
		GameController.ScrollScreen -= Scroll;
	}

	void Scroll () {
		pos.x -= 5f * Time.deltaTime;

		if (pos.x <= -16f) {
			pos.x = 16f;
		}

		transform.position = pos;
	}
}
