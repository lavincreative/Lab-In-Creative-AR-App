using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeEffectIntro : MonoBehaviour {

	private Image image;
	private Color color;

	private bool fadeOut = false;
	private bool once = true;

	public float fadeInSpeed = 1f;
	public float fadeOutSpeed = 1f;
	public float incrementVelocityPerFrame = 0.005f;
	public float waitTimeUntilEndScene = 1f;
	public string loadSceneName;

	void Start () {
		image = gameObject.GetComponent<Image> ();
		color.a = 0;

		StartCoroutine (WaitSomeSeconds (waitTimeUntilEndScene));
	}

	void Update () {
		if (!fadeOut && image) {			
			image.color = Color.Lerp (image.color, color, fadeInSpeed * Time.deltaTime);
			fadeInSpeed = fadeInSpeed + incrementVelocityPerFrame;
		}
		if (fadeOut) {
			if (once) {
				StartCoroutine (WaitSomeSeconds (waitTimeUntilEndScene / fadeOutSpeed));
				once = false;
			}

			image.color = Color.Lerp (image.color, color, fadeOutSpeed * Time.deltaTime);
			fadeOutSpeed = fadeOutSpeed + incrementVelocityPerFrame;
		}
	}

	IEnumerator WaitSomeSeconds(float x) {		
		yield return new WaitForSeconds (x);
		if (!fadeOut) {
			color.a = 1;
			fadeOut = true;
		} else {
			SceneManager.LoadScene (loadSceneName);	
		}
	}
}
