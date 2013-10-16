using UnityEngine;
using System.Collections;

public class ItemSpawnPoint : MonoBehaviour {
	
	public GameObject item;
	public float min = 0.5f;
	public float max = 1f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("SpawnItem");
		
	}
	
	IEnumerator SpawnItem(){
		while(true){
			float interval = Random.Range(min, max);
	
			Instantiate(item, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(interval);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
