using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public TextMesh scoreText;
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
    if (col.gameObject.tag == "Target") {
			AddScore(20);
		}
	}

	public void AddScore (int scoreValue) {
		score += scoreValue;
		UpdateScore();

	}

	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}
}
