using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("G");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
        }
	}
}

