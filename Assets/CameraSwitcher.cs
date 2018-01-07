using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

    public Camera firstCamera;
    public Camera secondCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            firstCamera.enabled = false;
            secondCamera.enabled = true;
            Debug.Log("space");
            Camera temp = secondCamera;
            secondCamera = firstCamera;
            firstCamera = temp;
        }

    }
}
