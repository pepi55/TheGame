using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public static Vector2 pos;

	void Start () {
		pos = transform.position;
	}

	void OnEnable () {
		GameController.StartGame += Move;
		GameController.PlayerInput += ButtonPress;
	}

	void OnDisable () {
		GameController.StartGame -= Move;
		GameController.PlayerInput -= ButtonPress;
	}

	private void Move () {
		pos.x += 3f * Time.deltaTime;

		transform.position = pos;
	}

	private void ButtonPress () {

	}
}
