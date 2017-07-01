using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalRotation : MonoBehaviour
{
	#region Variables

	public enum RotationTowards
	{
		X,
		Y,
		Z
	}

	public RotationTowards rotationTowards;
	[Range (-100, 100)]
	public float speed = 10;
	[Tooltip ("Whether the rotaion should be Time.deltaTime")]
	public bool detaTimeDependent = true;

	#endregion

	#region Init

	// Use this for initialization
	void Start ()
	{
		
	}

	#endregion

	#region Update

	// Update is called once per frame
	void Update ()
	{
		transform.localEulerAngles = new Vector3 (
			transform.localEulerAngles.x + (rotationTowards == RotationTowards.X ? speed : 0) * (detaTimeDependent ? Time.deltaTime : 1),
			transform.localEulerAngles.y + (rotationTowards == RotationTowards.Y ? speed : 0) * (detaTimeDependent ? Time.deltaTime : 1),
			transform.localEulerAngles.z + (rotationTowards == RotationTowards.Z ? speed : 0) * (detaTimeDependent ? Time.deltaTime : 1)
		);
	}

	#endregion
}
