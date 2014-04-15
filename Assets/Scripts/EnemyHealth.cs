using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			Debug.Log ("it works");
		
	}
}
