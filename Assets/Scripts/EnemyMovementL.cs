using UnityEngine;
using System.Collections;

public class EnemyMovementL : MonoBehaviour {

	private Vector2 EnemyPos;



	// Use this for initialization
	void Start () 
	{
		EnemyPos = transform.position;


	}
	
	// Update is called once per frame
	void Update () 
	{
		EnemyPos.x -= -5f * Time.deltaTime;
		if (EnemyPos.x >= 0f) 
		{
			EnemyPos.x = 0f * Time.deltaTime;

		}


		transform.position = EnemyPos;
	}
		

} 

