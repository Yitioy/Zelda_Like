using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public float Health;
	public float DamageTaken;

	// Use this for initialization
	void Start () 
	{
		DamageTaken = ShotScript.Damage;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Health <= 0f) 
		{
			Destroy (gameObject);
		}			
	}
}
