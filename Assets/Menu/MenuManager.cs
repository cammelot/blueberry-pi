using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	
	public GUITexture start;
	public GUITexture option;
	public GUITexture end;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(start.HitTest(Input.mousePosition)&&Input.GetMouseButton(0))
			Application.LoadLevel("a");
	}
}
