﻿using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	Rigidbody rb;

	public float tumble;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
