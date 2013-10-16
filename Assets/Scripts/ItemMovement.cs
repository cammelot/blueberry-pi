using UnityEngine;
using System.Collections;

public class ItemMovement : MonoBehaviour {
	
	private Vector3 startPoint = new Vector3(Random.Range(0, 5), Random.Range(0, 5), 50);
	private Vector3 speed =  new Vector3(0, 0, 30) ;
	
	// Use this for initialization
	void Start () {
		
		//Transform target = GameObject.Find("m346").transform;
			
		//transform.position = target.position + new Vector3(0, 0, 50);	
		transform.position = startPoint;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position-=speed*Time.deltaTime;
		
		if(transform.position.z <= -50){
		Destroy(gameObject);
		}
	
	}
}
