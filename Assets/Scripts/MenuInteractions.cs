using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MenuInteractions : MonoBehaviour {

	public GameController gameController;
	bool defaultTips;
	public VRTK_ControllerTooltips leftTips;
	public VRTK_ControllerTooltips rightTips;

	// Use this for initialization
	void Start () {
		defaultTips = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void EndGame () {
		Application.Quit();
	}

	public void ResetScore () {
		gameController.score = 0;
		gameController.UpdateScore();
	}

	public void ToggleTooltips () {
		if (defaultTips == true) {
			leftTips.ToggleTips(false);
			rightTips.ToggleTips(false);
		} else {
			leftTips.ToggleTips(true);
			rightTips.ToggleTips(true);
		}
	}
}
