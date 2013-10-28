using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	
	public int timeLimit = 10;
	
	private float timeRemaining;
	
	private bool timerStarted;

	// Use this for initialization
	void Start () {
		
		ResetTimer();
		timerStarted = true;//나중에 StartTimer()사용하고 지우기
	
	}
	
	public void ResetTimer(){
		timeRemaining = timeLimit;
		timerStarted = false;
	}
	
	public void StartTimer(){
		timerStarted = true;
	}
	
	public void StopTimer(){
		timerStarted = false;
	}
	
	public float GetTimeRemaining(){
		return timeRemaining;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(timerStarted){
			timeRemaining -= Time.deltaTime;
			if(timeRemaining <= 0){
				timeRemaining = 0;
				timerStarted = false;
			}
		}
		guiText.text = "Time : "+timeRemaining;
	}
}
