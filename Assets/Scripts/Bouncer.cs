using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour {

    [SerializeField]
    int score = 100;

    [SerializeField]
    float forceMin = 0f, forceMax = 0f;

    [SerializeField]
    float angleMin = 0f, angleMax = 0f;

    [SerializeField]
    float rotationMin = 0f, rotationMax = 0f;

    private AudioSource audioSource;

	private void Awake() {
        audioSource = GetComponent<AudioSource>();
		
	}

	private void OnCollisionEnter(Collision collision)
	{
        if (!collision.gameObject.CompareTag("Ball")) return;
        Vector3 exitDirection = -collision.contacts[0].normal;
        Quaternion randomRotation = Quaternion.AngleAxis(Random.Range(angleMin, angleMax), Vector3.up);
        exitDirection = randomRotation * exitDirection;
        collision.rigidbody.AddForce(exitDirection * Random.Range(forceMin, forceMax), ForceMode.Acceleration);
        Score.instance.AddScore(score * ((int)collision.relativeVelocity.magnitude+1));
        if (audioSource) {
            audioSource.Play();
        }
	}

	private void OnCollisionExit(Collision collision)
	{
        if (transform.childCount > 0) {
            Rigidbody lights = transform.GetChild(0).GetComponent<Rigidbody>();
            if (lights)
            {
                lights.AddTorque(Vector3.up * Random.Range(rotationMin, rotationMax), ForceMode.Acceleration);
            }
        }
	}
}
