﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterCombat : MonoBehaviour {

	public static bool InCombat = false;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{

	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
			InCombat = true;
	}
}