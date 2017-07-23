using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class ControllerMenu : MonoBehaviour {

	public GameObject basketball;
	public Text throwSpeed;
	public Color[] colors;
	private float speed;
	private int ballCount;
	private float maxSpeed;
	private GameObject newBall;
	public VRTK_InteractGrab grabbingController;


	// Use this for initialization
	void Start () {
		ballCount = 0;
		speed = 1;
		maxSpeed = 1;
		UpdateThrowSpeed();
	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnBall () {
		if (ballCount != 5) {
		newBall = Instantiate(basketball, grabbingController.transform.position, Quaternion.identity) as GameObject;
		newBall.transform.parent = null;
		newBall.name = "BasketballClone";
		grabbingController.GetComponent<VRTK_InteractTouch>().ForceTouch(newBall);
		grabbingController.AttemptGrab();
		ballCount += 1;
		} else {
			Destroy(newBall);
			ballCount -= 1;
		}
	}

	public void MoreThrowSpeed () {
		if (maxSpeed < 5) {
		speed = grabbingController.GetComponent<VRTK_InteractGrab>().throwMultiplier += 0.5f;
		maxSpeed = speed;
		UpdateThrowSpeed();
		}
	}

	public void LessThrowSpeed () {
		if (maxSpeed > 1) {
		speed = grabbingController.GetComponent<VRTK_InteractGrab>().throwMultiplier -= 0.5f;
		maxSpeed = speed;
		UpdateThrowSpeed();
		}
	}

	void UpdateThrowSpeed () {
		throwSpeed.text = speed.ToString();
	}

	public void ChangeColor () {
		var cIndex = Random.Range(0, colors.Length);
		foreach (Renderer r in newBall.GetComponentsInChildren<Renderer>()) {
			foreach (Material m in r.materials) {
				if (m.name == "Material (Instance)") {
					r.material.color = colors[cIndex];
				}
			}
		}
	}

}
