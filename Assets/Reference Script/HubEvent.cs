using UnityEngine;
using System.Collections;

public class HubEvent : MonoBehaviour {
	public float a, b, c, d;

	public void SetA (float x)
	{
		a = x;
	}
	public void SetB(float x)
	{
		b = x;
	}
	public void SetC(float x)
	{
		c = x;
	}
	public void SetD(float x)
	{
		d = x;
	}

	void Start(){
		a = b = c = d = 0;
		if(gameObject.tag == "CenterHub"){
			gameObject.SetActive(false);
		}
	}
	// Update is called once per frame
	void Update () {

	}

	public void CloseHub(){
		if (a == 3 && b == 3 && c == 3 && d == 3) {
			

		} else {
			Debug.Log ("Deactive");
		}
	}
}
