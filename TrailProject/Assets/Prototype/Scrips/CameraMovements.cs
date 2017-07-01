using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraMovements : MonoBehaviour
{

	#region Variables

	public GameObject movingCamera;
	[Tooltip ("Place the camera points in serial order")]
	public Transform[] cameraPoints;
	public Toggle smooth;
	public Text currentActivePointText;

	//---------> Private <-------//
	private int currentPointNumber;

	#endregion


	#region Init

	// Use this for initialization
	void Start ()
	{
		currentPointNumber = PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name + "count");
		Debug.Log ("Loading prefe: " + SceneManager.GetActiveScene ().name + "count" + " : " + PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name + "count"));
		currentActivePointText.text = "Current Point: " + currentPointNumber.ToString ();
		MoveToNextNode ();
	}

	#endregion


	#region Next/Previous points

	public void NextPoint ()
	{
		currentPointNumber++;
		if (currentPointNumber > cameraPoints.Length - 1) {
			currentPointNumber = 0;
		}

		MoveToNextNode ();
		
	}

	public void PreviousPoint ()
	{
		currentPointNumber--;
		if (currentPointNumber < 0) {
			currentPointNumber = cameraPoints.Length - 1;
		}
		MoveToNextNode ();

	}

	private void MoveToNextNode ()
	{
		currentActivePointText.text = "Current Point: " + currentPointNumber.ToString ();

		if (smooth.isOn) {
			iTween.MoveTo (movingCamera, cameraPoints [currentPointNumber].position, 0.25f);
			iTween.RotateTo (movingCamera, cameraPoints [currentPointNumber].eulerAngles, 0.25f);
		} else {
			movingCamera.transform.position = cameraPoints [currentPointNumber].position;
			movingCamera.transform.eulerAngles = cameraPoints [currentPointNumber].eulerAngles;
		}
	}

	#endregion

	#region Switch Scene

	public void SwitchScene (string sceneName)
	{
		PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name + "count", currentPointNumber);
		SceneManager.LoadScene (sceneName);	
	}

	#endregion

	#region Code Repo

	public void CodeRepo ()
	{
		Application.OpenURL (Constants.REPO_URL);
	}

	#endregion
}
