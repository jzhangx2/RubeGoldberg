using UnityEngine;
using System.Collections;

public class C2Trigger : MonoBehaviour {
	
	public Camera c1, c2, c3, c4;
	public Collider col1;
	public GameObject ball;
	
	void Start(){
		c1.enabled = true;
		c2.enabled = false;
		c3.enabled = false;
		c4.enabled = false;
	}
	void OnTriggerEnter(Collider other) {
		if (other == col1) {
			c1.enabled = false;
			c2.enabled = true;
		}
	}
}