using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour {

    [SerializeField]
    private float magnitude = 1f;

    [SerializeField]
    private Vector3 direction = Vector3.right;

    private AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

	private void Start() {		
	}

	private void OnTriggerStay(Collider other) {
        Rigidbody rb = other.attachedRigidbody;
        rb.AddForce(direction * magnitude, ForceMode.Acceleration);
	}

	private void OnTriggerEnter(Collider other) {
        if (audioSource) audioSource.Play();
		
	}
}