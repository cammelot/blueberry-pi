using UnityEngine;
using System.Collections;

public class TestLeapMotion : MonoBehaviour {
    static int id = 0;
	// Use this for initialization
	void Start () {
        LeapInput.HandUpdated += HandUpdatedHandler;
	}
	
	// Update is called once per frame
	void Update () {
        LeapInput.Update();
	}

    void HandUpdatedHandler(Leap.Hand hand)
    {


        Leap.Vector newPos = hand.PalmPosition;
		transform.position = new Vector3(newPos.x * 0.05f, newPos.y*0.05f - 10.0f);

        float Pitch = hand.PalmNormal.Pitch + Mathf.Deg2Rad*90;
        float Roll = hand.PalmNormal.Roll;

        Pitch = Mathf.Clamp(Pitch, -45 * Mathf.Deg2Rad, 45 * Mathf.Deg2Rad);

        transform.rotation = new Quaternion(-Pitch, 0, Roll, 1);
    }
}
