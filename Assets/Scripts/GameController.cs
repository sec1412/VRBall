using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class GameController : MonoBehaviour {

	public Text scoreText;
	public int score;

	// Use this for initialization
	void Start () {

		score = 0;
		UpdateScore();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		Debug.Log("test");
    if (col.gameObject.tag == "Basketball") {
			AddScore(20);
		}
	}

	public void AddScore (int scoreValue) {
		score += scoreValue;
		UpdateScore();

	}

	void UpdateScore () {
		scoreText.text = score.ToString();
	}
}
