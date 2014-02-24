using UnityEngine;
using System.Collections;

public class C3Trigger : MonoBehaviour {
	
	public Camera c2, c3;
	public Collider col2;
	
	void OnTriggerEnter(Collider other) {
		if (other == col2) {
			c2.enabled = false;
			c3.enabled = true;
		}
	}
}