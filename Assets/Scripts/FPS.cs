using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour {

    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames = 0;
    private float fps;

	// Use this for initialization
	void Start () {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
	}
	
	// Update is called once per frame
	void Update () {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            frames = 0;
            lastInterval = timeNow;
        }
	}

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.richText = true;
        var text = "<size=15><color=yellow>";
        text += "FPS " + (int)fps;
        text += "</color></size>";
        GUILayout.Label(text, style);
    }
}
