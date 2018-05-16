using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITarget {
    bool Triggered { get; set; }
}

public class Target : MonoBehaviour
{

    [SerializeField]
    private int score = 1000;

    [SerializeField]
    private GameObject[] validTargets = {};

    private ITarget[] targets;
    private int multiplier = 1;

	private void Awake() {
        targets = new ITarget[validTargets.Length];

        for (int i = 0; i < validTargets.Length; ++i) {
            targets[i] = validTargets[i].GetComponent<ITarget>();
        }
	}

	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
        		
	}

    IEnumerator SmallAnim() {
        yield return new WaitForSeconds(0.5f);
        ResetTriggered();
        for (int i = 0; i < targets.Length * 10; ++i) {
            for (int t = 0; t < targets.Length; ++t) {
                targets[t].Triggered = t == (i % targets.Length);
            }
            yield return new WaitForSeconds(0.25f);
        }
        ResetTriggered();
    }

	private void OnTriggerEnter(Collider other) {
        Score.instance.AddScore(score);
        GameObject og = other.gameObject;
        ITarget tar = og.GetComponent<ITarget>();

        if (tar == null) return;

        Debug.Log("Target: " + tar);
        tar.Triggered = true;

        if (CheckAllTriggered()) {
            multiplier += multiplier;
            Score.instance.AddScore(score * multiplier * targets.Length);
            StartCoroutine("SmallAnim");
        }
	}

    private bool CheckAllTriggered() {
        foreach(ITarget tar in targets) {
            if (tar.Triggered == false) return false;
        }
        return true;
    }

    private void ResetTriggered() {
        foreach (ITarget tar in targets) {
            tar.Triggered = false;
        }
    }
}
