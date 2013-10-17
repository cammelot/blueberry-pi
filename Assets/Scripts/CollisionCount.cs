using UnityEngine;
using System.Collections;

public class CollisionCount : MonoBehaviour {
	
	private int count;
	
	void Start(){
		
	}
	
	void Init(){
		this.count = 0;
	}
	
	void Count(){
		this.count += count;
	}
	
	void Update () {
		guiText.text = "Collision : "+this.count;
	}
}
