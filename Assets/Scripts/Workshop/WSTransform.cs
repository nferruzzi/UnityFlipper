// https://docs.unity3d.com/ScriptReference/Transform.html
// https://docs.unity3d.com/ScriptReference/Vector3.html
// https://docs.unity3d.com/ScriptReference/Quaternion.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (UnityEngine.Transform child in transform)
        {
            child.position += Vector3.up * 10.0F;
        }

        Vector3 a = new Vector3(10f, 10f, 10f);
        Vector3 b = a * 100f;
        Vector3.Lerp(a, b, Time.deltaTime);
        var d = Vector3.Dot(a, b);
        // .. 

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), Time.deltaTime);

	}
}
