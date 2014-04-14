using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//gameobjects
	private GameObject player;

	//events
	public delegate void PlayerActions();
	public static event PlayerActions PlayerInput;
	public static event PlayerActions StartGame;

	// Use this for initialization
	void Start () {
		player = (GameObject)Instantiate(Resources.Load(GlobalValues.playerPath), new Vector2(-10f, -1f), Quaternion.identity);
		player.name = GlobalValues.playerName;
		player.tag = GlobalValues.playerTag;

		if (StartGame != null) {
			StartGame();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			if (PlayerInput != null) {
				PlayerInput();
			}
		}
	}
}
