using UnityEngine;
using System.Collections;

public class CollisionCount : MonoBehaviour {
	
	public static int count;
	
	void Start(){
		/*
		GameObject go = GameObject.FindObjectOfType(typeof(ObstacleBase))as GameObject;	
		ObstacleBase broken = go.Getcomponent*/
	}
	
	void Init(){
		
		//count = GameObject.Find("BrokenCount").GetComponent<CollisionCount>;
		CollisionCount.count = 0;
	}
	
	void Count(){
		Debug.Log("call");
		CollisionCount.count++;
	}
	
	void Update () {
		/*if(ObstacleBase.brokenObstacle){
			Count();
		}*/
		guiText.text = "Collision : "+CollisionCount.count;
	}
}
