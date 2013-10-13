using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {
	public GameObject debri;
	public float min = 0.01f;
	public float max = 0.05f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("SpawnDebris");
		
	}
	
	IEnumerator SpawnDebris(){
		while(true){
			float interval = Random.Range(min, max);
	
			Instantiate(debri, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(interval);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
