﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider otherCollider)
	{
		
		/*if (otherCollider.GetComponent<ObstacleBase>())
			Destroy(gameObject);*/

		if (otherCollider.GetComponent<ItemBase>())
			Destroy(otherCollider.gameObject);
		
	}
}
