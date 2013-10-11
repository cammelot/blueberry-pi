using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	
	private Vector2 startPos;
	
	void Update () {
		float moveX = 0f;	
		float moveY = 0f;	
	
		if (Input.GetMouseButtonDown(0)) {
			startPos = Input.mousePosition;
		} else if (Input.GetMouseButton(0)) {
			moveX = Input.mousePosition.x - startPos.x;
			moveY = Input.mousePosition.y - startPos.y;
			startPos = Input.mousePosition;
		} else if (Input.GetMouseButtonUp(0)) {
			startPos = Vector2.zero;
		}
		if (transform.rotation.eulerAngles.x - moveY  >= 50) {
			moveY = 0;
		}
		if (transform.rotation.eulerAngles.x - moveY <= 0) {
			moveY = 0;
		}
		transform.Rotate(-moveY, 0, 0);
		transform.Rotate(0, moveX, 0, Space.World);
	}
}
