using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {

	private Vector3 speed =  new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(10, 50)) ;
	public Vector3 angle = new Vector3(Random.Range(50f, 100f), Random.Range(50f, 100f), Random.Range(50f, 100f));

	// Use this for initialization
	void Start () {
		
		transform.position = new Vector3(0, 0, 50);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position-=speed*Time.deltaTime;
		transform.Rotate(angle*Time.deltaTime);
		
		if(transform.position.z <= -50){
		Destroy(gameObject);
		}
	
	}
}
