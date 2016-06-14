using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using SmartLocalization;

public class LangController : MonoBehaviour {

	private Text welcomteToText;
	private Text theAppText;
	private TextMeshProUGUI textMeshPro;

	// Use this for initialization
	void Start () {
		
		welcomteToText = GameObject.Find ("WelcomeToText").GetComponent<Text> ();
		theAppText = GameObject.Find ("TheAppText").GetComponent<Text> ();
		textMeshPro = GameObject.Find ("TextMeshPro").GetComponent<TextMeshProUGUI> ();

		if(PlayerPrefs.GetString("LANG") == "es") {
			Spanish ();
		}

		if(PlayerPrefs.GetString("LANG") == "en") {
			English ();
		}

		welcomteToText.text = LanguageManager.Instance.GetTextValue ("WelcomeToText");
		theAppText.text = LanguageManager.Instance.GetTextValue ("TheAppText");
		textMeshPro.text = LanguageManager.Instance.GetTextValue ("NewChallenge");
	}

	public void Spanish() {
		LanguageManager.Instance.ChangeLanguage ("es");
		PlayerPrefs.SetString ("LANG", "es");
	}

	public void English() {
		LanguageManager.Instance.ChangeLanguage ("en");
		PlayerPrefs.SetString ("LANG", "en");
	}

	// Update is called once per frame
	void Update () {
		welcomteToText.text = LanguageManager.Instance.GetTextValue ("WelcomeToText");
		theAppText.text = LanguageManager.Instance.GetTextValue ("TheAppText");
		textMeshPro.text = LanguageManager.Instance.GetTextValue ("NewChallenge");
	}
}
