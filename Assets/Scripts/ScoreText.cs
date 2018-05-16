using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    private Text myText;

	private void Awake() {
        myText = GetComponent<Text>();		
	}

	// Use this for initialization
	void Start () {
        Score.scoreDelegate += NewScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void NewScore(float score) {
        myText.text = "" + (int)score;
    }
}
