//******************************************************************************************************
// Latest Update : 5/28/2018
// Author : Isabella Liu
// this script should be attached to the main viewing 3D object on the central of the screen 
// Function : enable mouse implementation to the 3D object viewing browser
//            [Left Button] + [Mouse Move]      -->    Rotate 3D model
// SDK Requirement : None 
// Notification : None 
//*******************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour {

    public float rotateScale = 2.0f;  // the scale of the rotation when user move mouse

    private GameObject MainCamera;

	// Use this for initialization
	void Start () {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 fwd = MainCamera.transform.forward;
        fwd.Normalize();
        if (Input.GetMouseButton(0))   // if the left button of the button was pressed 
        {
            Vector3 vaxis = Vector3.Cross(fwd, Vector3.right);
            Vector3 haxis = Vector3.Cross(fwd, Vector3.up);
            transform.Rotate(vaxis, -Input.GetAxis("Mouse X") * rotateScale , Space.World);
            transform.Rotate(haxis, -Input.GetAxis("Mouse Y") * rotateScale, Space.World);
        }
	}
}
