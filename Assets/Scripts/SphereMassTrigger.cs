using UnityEngine;
using System.Collections;

public class SphereMassTrigger : MonoBehaviour {

	public Collider col1;
	public GameObject ball;
	public int myMass=0;
	public Camera c3, c4;

	void OnTriggerEnter(Collider other) {
		if (other == col1) {
			ball.rigidbody.mass = myMass;
			c3.enabled=false;
			c4.enabled=true;
		}
	}
}