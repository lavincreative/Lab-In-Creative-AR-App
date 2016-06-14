using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		GameObject go = new GameObject("LevelManager");
		LevelManager instance = go.AddComponent<LevelManager>();
		StartCoroutine (InnerLoad (name));
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	IEnumerator InnerLoad(string name) {
		//load transition scene
		Object.DontDestroyOnLoad(this.gameObject);
		SceneManager.LoadScene ("LoadingScene");

		//wait one frame (for rendering, etc.)
		yield return null;

		//load the target scene
		SceneManager.LoadScene (name);
		Destroy(this.gameObject);
	}
}
