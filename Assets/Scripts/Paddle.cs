using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public KeyCode trigger;
    private float baseAngle;

	// Use this for initialization
	void Start () {
        baseAngle = transform.localRotation.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(trigger))
        {
            GetComponent<Rigidbody2D>().MoveRotation(-baseAngle);
        }
        else if (Input.GetKeyUp(trigger))
        {
            GetComponent<Rigidbody2D>().MoveRotation(baseAngle);
        }
    }
}
