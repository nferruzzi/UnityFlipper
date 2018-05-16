// https://docs.unity3d.com/ScriptReference/Rigidbody.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSRigidbody : MonoBehaviour {

    public Rigidbody rb;

    void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        //rb.MovePosition(transform.position + transform.forward * 0.1f);

        //rb.AddForce(Vector3.up, ForceMode.Acceleration);

        //rb.AddTorque(Vector3.up);
    }

	private void OnCollisionEnter(Collision collision) {		
        Debug.Log("Collision Enter " + this);
	}

	private void OnCollisionStay(Collision collision) {		
        Debug.Log("Collision Stay " + this);
	}

	private void OnCollisionExit(Collision collision) {
        Debug.Log("Collision Exit " + this);
	}

	private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger Enter " + this);
	}

	private void OnTriggerStay(Collider other) {
        Debug.Log("Trigger Stay " + this);		
	}

    private void OnTriggerExit(Collider other) {
        Debug.Log("Trigger Exit " + this);
    }

}
