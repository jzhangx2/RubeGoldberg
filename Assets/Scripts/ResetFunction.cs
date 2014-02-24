using UnityEngine;
using System.Collections;

public class ResetFunction : MonoBehaviour {

	public GameObject ball;
	int temp=0;
	// Update is called once per frame
	void Update () {
		if (temp == 15) {
			renderer.material.SetColor ("_Color", new Color(Random.value, Random.value, Random.value));
			temp=0;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Time.timeScale=4;
			Physics.gravity=new Vector3(0f, -9.81f, 0f);
			ball.rigidbody.mass = 5;
			Application.LoadLevel(0);
		}
		temp++;
	}

	Color RandomColor() {
		return new Color(Random.value, Random.value, Random.value);
	}
}
