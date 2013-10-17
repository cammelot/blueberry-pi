using UnityEngine;
using System.Collections;

public class ItemSpawnPoint : MonoBehaviour {
	
	public GameObject item;
	public float min = 5f;
	public float max = 10f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("SpawnItem");
		
	}
	
	IEnumerator SpawnItem(){
		while(true){
			float interval = 5;//이부분 이상함
	
			Instantiate(item, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(interval);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
