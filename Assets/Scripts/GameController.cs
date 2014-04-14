using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//gameobjects
	private GameObject player;

	//events
	public delegate void PlayerActions();
	public static event PlayerActions PlayerInput;
	public static event PlayerActions StartGame;

	public delegate void Parrallax();
	public static event Parrallax ScrollScreen;

	// Use this for initialization
	void Start () {
		player = (GameObject)Instantiate(Resources.Load(GlobalValues.playerPath), new Vector2(-10f, -1f), Quaternion.identity);
		player.name = GlobalValues.playerName;
		player.tag = GlobalValues.playerTag;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerController.pos.x <= -3f) {
			if (StartGame != null) {
				StartGame();
			}
		}

		if (PlayerController.pos.x >= -2.9f) {
			if (ScrollScreen != null) {
				ScrollScreen();
			}
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			if (PlayerInput != null) {
				PlayerInput();
			}
		}
	}
}
