using UnityEngine;
using System.Collections;

public class playerFollow : MonoBehaviour {
	public Transform Player;
	public float Rotation;

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - Player.position;
	}

	void Update()
	{
		float y = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		this.transform.Rotate (new Vector3 (0f, y, 0f * Rotation * Time.deltaTime));

		transform.position = Player.position + offset;
	}
}
