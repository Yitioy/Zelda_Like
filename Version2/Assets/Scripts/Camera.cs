﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


	public Transform player;
	public float speed;
	public float smooth;
	private Vector3 velocity;
	void Start()
	{
		player = GameObject.Find("Player").transform;
	}

	void FixedUpdate()
	{
		Vector3 positionCache = new Vector3(player.position.x, player.position.y, player.position.z - 3);
		transform.position = Vector3.SmoothDamp (transform.position, positionCache, ref velocity, smooth);
	}                                           
}