using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChild : MonoBehaviour, ITarget {

    [SerializeField]
    private Color triggeredColor = Color.green, notTriggeredColor = Color.red;
    private bool triggered = false;

    private Material currentMaterial;

    void Awake() {
        currentMaterial = GetComponentInChildren<Renderer>().material;
    }

	// Use this for initialization
	void Start () {
        triggered = false;
	}	

	// Update is called once per frame
	void Update () {
	}

    public bool Triggered {
        get { return triggered;  }
        set { 
            triggered = value;
            currentMaterial.SetColor("_Color", triggered ? triggeredColor : notTriggeredColor);
        }
    }
}
