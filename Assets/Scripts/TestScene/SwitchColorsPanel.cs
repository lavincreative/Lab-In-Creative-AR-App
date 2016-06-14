using UnityEngine;
using System.Collections;

public class SwitchColorsPanel : MonoBehaviour {

	private bool isOff = true;

	public void SwitchOnOff() {
		if (isOff) {
			gameObject.GetComponent<Animator> ().SetTrigger ("isOn");
			isOff = false;
		} else {
			gameObject.GetComponent<Animator> ().SetTrigger ("isOff");
			isOff = true;
		}
	}
}
