using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMono : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScreenRaycastPanel();
	}

    void ScreenRaycastPanel()   // judge whether user is touching the scrollbar 
    {
        if (Input.GetMouseButton(0))    // if the left button of the mouse was pressed, cast a ray from the screen 
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // transform the mouse position into a ray in the world space
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Model")  // if user is clicking the model area
                    Global.ModelRotate = true;
                else
                    Global.ModelRotate = false;
            }
        }
        else
            Global.ModelRotate = false;
    }
}

public class Global
{
    public static bool ModelRotate = false;   // whether current user is scrolling the object list window
}

