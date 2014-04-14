using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Vector2 pos;

	void Start () {
		pos = transform.position;
	}

	void OnEnable () {
		GameController.StartGame += Move; Debug.Log("added");
		GameController.PlayerInput += ButtonPress;
	}

	void OnDisable () {
		GameController.StartGame -= Move;
		GameController.PlayerInput -= ButtonPress;
	}

	private void Move () {
		Debug.Log("test");
		if (pos.x <= -3f) {
			pos.x += 3f * Time.deltaTime;
		}
	}

	private void ButtonPress () {

	}
}
