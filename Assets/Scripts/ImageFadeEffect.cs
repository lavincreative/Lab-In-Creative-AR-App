using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFadeEffect : MonoBehaviour {

	private Image image;
	private Color color;

	public float fadeSpeed = 0.003f;

	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<Image> ();
		color = new Color(255,255,255,0);
		image.color = color;
		color = new Color(255,255,255,255);
	}
	
	// Update is called once per frame
	void Update () {
		if (image) {			
			image.color = Color.Lerp (image.color, color, fadeSpeed * Time.deltaTime);	
		}
	}
}
