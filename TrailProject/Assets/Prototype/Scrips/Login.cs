using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{

	#region Variables

	public InputField userNameField;
	public InputField passwordField;
	public Text errorMessage;

	#endregion

	#region Init

	// Use this for initialization
	void Start ()
	{
		
	}

	#endregion


	#region Login check

	public void TryLogin ()
	{
		errorMessage.text = "";

		if (userNameField.text != Constants.USERNAME) {
			errorMessage.text = Constants.ERROR_USERNAME;
			return;
		} 

		if (passwordField.text != Constants.PASSWORD) {
			errorMessage.text = Constants.ERROR_PASSWORD;
			return;
		}
		LoginSccessful ();
	}


	private void LoginSccessful ()
	{
		SceneManager.LoadScene (Constants.SCENE_DEMO1);
	}

	#endregion
}
