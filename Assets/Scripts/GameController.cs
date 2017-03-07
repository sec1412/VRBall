using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class GameController : MonoBehaviour {

	public Text scoreText;
	public Text scoreMultiplierText;
	public Text bonusTimeText;
	private float score;
	private float bonusTime;
	private float scoreMultiplier;

	// Use this for initialization
	void Start () {

		score = 0;
		scoreMultiplier = 1;
		bonusTime = 0;
		UpdateScore();
		UpdateBonusTime();
		UpdateScoreMultiplier();
		InvokeRepeating ("BonusTimer", 1.0f, 1.0f);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		Debug.Log("test");
    if (col.gameObject.tag == "Basketball") {
			AddScore(20f * scoreMultiplier);
			scoreMultiplier += 0.5f;
			UpdateScoreMultiplier();
			bonusTime = 20f;

		}
	}

	public void AddScore (float scoreValue) {
		score += scoreValue;
		UpdateScore();

	}

	void UpdateScore () {
		scoreText.text = score.ToString();
	}

	void UpdateBonusTime () {
		bonusTimeText.text = bonusTime.ToString();
	}

	void UpdateScoreMultiplier () {
		scoreMultiplierText.text = scoreMultiplier.ToString();
	}

	void BonusTimer () {
		if (bonusTime != 0) {
		if (--bonusTime == 0) {
			scoreMultiplier = 1;
			UpdateScoreMultiplier();
			//CancelInvoke ("BonusTimer");

		}
		UpdateBonusTime();
		}
	}
}
