using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Collision : MonoBehaviour {

	public Text countText;
	public Text winText;
	private int count;

	public AudioClip sound;
	private AudioSource source {get { return GetComponent<AudioSource> ();}}

	void Start ()
	{
		count = 0;
//		SetCountText ();
		winText.text = "";

		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("PickUpCube")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
//			SetCountText ();

			PlaySound ();
		}	
	}

//	void SetCountText ()
//	{
//		countText.text = "Count: " + count.ToString ();
//		if (count >= 15)
//		{
//			winText.text = "You Win!";
//		}
//	}

	void PlaySound (){
		source.PlayOneShot (sound);
	}
}
