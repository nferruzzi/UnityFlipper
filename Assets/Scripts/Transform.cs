using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour {

    [SerializeField]
    float speed = 180f;

    Menu menu;

	private void Awake() {
        GameObject world = GameObject.Find("World");
        menu = world.GetComponent<Menu>();
	}

	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
        if (menu.isLoading) {
            transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        }
	}
}
