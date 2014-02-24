using UnityEngine;
using System.Collections;

public class Yaaaayyyyyyy : MonoBehaviour {
	
	public Collider col1;
	public float myGrav=1f;	
	public int myTime=0;

	void OnTriggerEnter(Collider other) {
		if (other == col1) {
			Physics.gravity=new Vector3(0, -myGrav, 0);
			Time.timeScale = myTime;
		}
	}
}