using UnityEngine;
using System.Collections;

public class ObstacleBase : MonoBehaviour {
	
	public GameObject brokenObstaclesPrefab;

	// Use this for initialization
	void Start () {
		//count = GameObject.Find("BrokenCount").GetComponent<CollisionCount>;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter(Collider otherCollider)
	{
		if (otherCollider.GetComponent<Player>())
		{
			Instantiate(brokenObstaclesPrefab, transform.position, brokenObstaclesPrefab.transform.rotation);
			Destroy(gameObject);
			
			
		}	
	}
}
