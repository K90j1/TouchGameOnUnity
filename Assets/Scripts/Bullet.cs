﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
	public int speed = 10;
	
	void Start ()
	{
		rigidbody2D.velocity = transform.up.normalized * speed;
	}
}