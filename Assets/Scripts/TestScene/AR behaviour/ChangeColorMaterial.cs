using UnityEngine;
using System.Collections;

public class ChangeColorMaterial : MonoBehaviour {

	public Material materialToChange;
	public Color[] color = new Color[5];

	public void greenColor() {
		materialToChange.color = color[0];
	}

	public void redColor() {
		materialToChange.color = color[1];
	}

	public void blueColor() {
		materialToChange.color = color[2];
	}

	public void yellowColor() {
		materialToChange.color = color[3];
	}

	public void purpleColor() {
		materialToChange.color = color[4];
	}
}
