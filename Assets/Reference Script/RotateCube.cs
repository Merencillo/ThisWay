using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {

		if (Input.GetButtonDown ("Fire2")){
			transform.Rotate (transform.rotation.eulerAngles + new Vector3(0f, 0.1f,0f));
		}

		if (Input.GetButtonDown ("Fire3")) {

			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0f, 0.1f));

		}
	}

	public void RotateHorizontal()
	{
		transform.Rotate (transform.rotation.eulerAngles + new Vector3(0f, 0.2f,0f));
	}

	public void RotateVertical()
	{
		transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0f, 0.3f));
	}
}
