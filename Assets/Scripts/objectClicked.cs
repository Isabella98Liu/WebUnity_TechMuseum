//******************************************************************************************************
// Latest Update : 5/30/2018
// Author : Isabella Liu
// this script should be attached to each item button on the item list  
// Function : record the last one button clicked by user
// SDK Requirement : None 
// Notification : None 
//*******************************************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectClicked : MonoBehaviour {

    public GameObject mainModel;
    public GameObject itemModel;

	// Use this for initialization
	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
	}

    void OnClick()
    {
        Debug.Log(this.name);
        for (int i = 0; i < mainModel.transform.childCount; i++)    // destroy all childs under mainModel and add correspond item model under it 
            Destroy(mainModel.transform.GetChild(i).gameObject);
        GameObject item = Instantiate(itemModel);
        item.transform.parent = mainModel.transform;
    }
}
