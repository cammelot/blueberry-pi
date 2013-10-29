using UnityEngine;
using System.Collections;
using Leap;

public class ObjectMovement : MonoBehaviour {
    Leap.Controller controller;
	//private Vector3 speed =  new Vector3(0,0, Random.Range(30, 80)) ;
	private static Vector3 speed =  new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(30, 80)) ;
	public Vector3 angle = new Vector3(Random.Range(50f, 100f), Random.Range(50f, 100f), Random.Range(50f, 100f));
    public static Vector3 ac = new Vector3(1.0F, 1.0F, 1.0F);

	// Use this for initialization
	void Start () {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

		//Transform target = GameObject.Find("m346").transform;
			
		//transform.position = target.position + new Vector3(0, 0, 50);	
		transform.position = new Vector3(x, y, z);
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPESCREENTAP);
	}

	// Update is called once per frame
	void Update () {
        Frame frame = controller.Frame();
        foreach (Gesture gesture in frame.Gestures())
        {
            switch (gesture.Type)
            {
                case (Gesture.GestureType.TYPESCREENTAP):
                    {
                        Debug.Log(speed.z);
                        ac.x += 0.2F;
                        ac.y += 0.2F;
                        ac.z += 0.2F;
                        if (speed.z <= 120)
                        {
                            speed.x += 2;
                            speed.y += 2;
                            speed.z += 10;
                        }
                        break;
                    }
            }
        }
        transform.position -= speed * Time.deltaTime;
        transform.Rotate(angle * Time.deltaTime);
		if(transform.position.z <= -50){
		Destroy(gameObject);
		}
        


	
	}
}
