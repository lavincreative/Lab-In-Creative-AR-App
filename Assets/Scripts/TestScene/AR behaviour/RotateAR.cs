using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateAR : MonoBehaviour {

	public Slider slider;
	public int velocity = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (new Vector3 (0, 0, slider.value * velocity * Time.deltaTime));
	}
}
