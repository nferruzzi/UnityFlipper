// https://docs.unity3d.com/ScriptReference/GameObject.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSGameObject : MonoBehaviour {

	// Use this for initialization
	private void Awake() {
        // Cercare
        var go = GameObject.FindWithTag("Ball");

        // Clonare
        var clone = Instantiate(go);
        clone.transform.position += Vector3.right * 2.0f;

        go.SendMessage("FuncFaiCose", 1.0f);
	}

}
