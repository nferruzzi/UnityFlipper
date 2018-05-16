using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

    private HingeJoint cerniera;

    [SerializeField]
    private string axis = "";

    [SerializeField]
    private float springTargetPressed = 0f, springTargetRested = 0f, springDamper = 0f, springValue = 0f;

	void Start () {
        cerniera = GetComponent<HingeJoint>();
        cerniera.useSpring = true;
	}
	
	private void FixedUpdate() {
        JointSpring spring = new JointSpring();
        spring.damper = springDamper;
        spring.spring = springValue;

        var force = Input.GetAxis(axis);

        if (force > 0f) {
            spring.targetPosition = springTargetPressed;
        } else {            
            spring.targetPosition = springTargetRested;
        }

        cerniera.spring = spring;
	}
}
