// https://docs.unity3d.com/ScriptReference/MonoBehaviour.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSMonoBehaviour : MonoBehaviour {

    // Use this to save references to components
	private void Awake() {
        Rigidbody rb = GetComponent<Rigidbody>();
        Debug.Log("My Rigidbody: " + rb);
	}

	// Use this for initialization
	private void Start () {		
	}
	
	// Update is called once per frame
	private void Update () {
        Debug.Log("Update " + Time.deltaTime);
	}

    // Update every fixed framerate frame
	private void FixedUpdate() {
        Debug.Log("Fixed update " + Time.deltaTime);		
	}

    // At the end of every frame
	private void LateUpdate() {
		
	}

    // For handling GUI events
	private void OnGUI() {
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
        {
            print("You clicked the button!");
        }		
	}

	private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * 100);
        Gizmos.DrawSphere(Vector3.zero, 10f);
	}
}
