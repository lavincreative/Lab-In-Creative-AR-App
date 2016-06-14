using UnityEngine;
using System.Collections;

public class AnimationIntroScene : MonoBehaviour {

	public GameObject welcomeText;
	public GameObject logotype;
	public GameObject theAppText;
	public GameObject nextSceneButton;

	public float welcomeTextTime;
	public float logotypeTime;
	public float theAppTextTime;
	public float nextSceneButtonTime;

	// Use this for initialization
	void Start () {
		StartCoroutine (WaitingAnimationsScene ());
	}
	
	IEnumerator WaitingAnimationsScene() {
		yield return new WaitForSeconds (welcomeTextTime);
		welcomeText.SetActive (true);
		yield return new WaitForSeconds (logotypeTime);
		logotype.SetActive (true);
		yield return new WaitForSeconds (theAppTextTime);
		theAppText.SetActive (true);
		yield return new WaitForSeconds (nextSceneButtonTime);
		nextSceneButton.SetActive (true);
	}
}
