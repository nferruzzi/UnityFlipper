using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Score : MonoBehaviour {

    private float score = 0f;
    private float curScore = 0f;

    public static Score instance;
    [SerializeField]
    float minInc = 10f;

    public delegate void ScoreDelegate(float score);
    public static event ScoreDelegate scoreDelegate;

	public void Awake() {
        if (Score.instance == null) {
            Score.instance = this;
        } else {
            if (Score.instance != this) {
                Destroy(this);
            }
        }
	}

	public void AddScore(int value)
    {
        score += value;
        Debug.Log("Added: " + value);
    }

	private void Update() {
        float val = Mathf.Max(score - curScore, minInc) * Time.deltaTime;
        curScore += val;
        curScore = Mathf.Min(curScore, score);
        if (scoreDelegate != null) scoreDelegate(curScore);
	}

}
