using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class ContactMail : MonoBehaviour {

	private string userName;
	private string userEmail;
	private string userSubject;
	private string userMessage;

	private bool mailSent = false;

	void Start () {
		userName = GameObject.Find ("EnterNameText").GetComponent<Text> ().text;
		userEmail = GameObject.Find ("EnterEmailText").GetComponent<Text> ().text;
		userSubject = GameObject.Find ("EnterSubjectText").GetComponent<Text> ().text;
		userMessage = GameObject.Find ("EnterMessageText").GetComponent<Text> ().text;
	}

	public void SendEmail() {
		MailMessage mail = new MailMessage ();
		mail.From = new MailAddress ("Lab In Creative App <lavin.sti@gmail.com>");
		mail.To.Add ("lavin.sti@gmail.com");
		mail.Subject = userName + " : " + userSubject + " : " + userEmail;
		mail.Body = userMessage;
		SmtpClient smtpServer = new SmtpClient ("smtp.gmail.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential ("lavin.sti@gmail.com", "20061988.L@VyNi") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback =
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{ return true; };
		smtpServer.Send(mail);
		Debug.Log("success");
		mailSent = true;
		CleanForm ();
	}

	public void CleanForm() {		
		GameObject.Find ("InputFieldName").GetComponent<InputField> ().text = "";
		GameObject.Find ("InputFieldEmail").GetComponent<InputField> ().text = "";
		GameObject.Find ("InputFieldSubject").GetComponent<InputField> ().text = "";
		GameObject.Find ("InputFieldMessage").GetComponent<InputField> ().text = "";
		if(mailSent) {
			GameObject.Find ("ConfirmedText").GetComponent<Text> ().text = "Your email has been sent.";
			mailSent = false;
		} else {
			GameObject.Find ("ConfirmedText").GetComponent<Text> ().text = "";
		}
	}
}
