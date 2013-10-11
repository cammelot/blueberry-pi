using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private static GameManager instance = null;
	public static GameManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType(typeof(GameManager)) as GameManager;
				System.Diagnostics.Debug.Assert(false, "fail to get gamemanager");
			}
			
			return instance;
		}
		set
		{
			if (instance == null)
			{
				instance = value;
			}
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
