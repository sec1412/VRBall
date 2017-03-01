using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenu : MonoBehaviour {

	public GameObject basketball;
	private int ballCount;
	private GameObject instObj;


	// Use this for initialization
	void Start () {
		ballCount = 0;
	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnBall () {
		if (ballCount != 5) {
		instObj = Instantiate (basketball, transform.position+(transform.forward*2), transform.rotation);
		ballCount += 1;
		}
	}
}
