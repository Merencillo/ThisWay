using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenServerDoor : MonoBehaviour {
	public bool Opendoor;
	private Animator anim;
	private GameObject player;

	private bool BtnOne;
	private bool BtnTwo;
	private bool BtnThree;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator> ();
		if(BtnOne && BtnTwo && BtnThree){
			anim.SetBool ("Opendoor",true);
        }
//		else if(Wrong){
//			anim.SetBool ("Opendoor",false);
//		}
	}

	public void SetBtnOne(){
		BtnOne = true;
	}

	public void SetBtnTwo(){
		BtnTwo = true;
	}

	public void SetBtnThree(){
		BtnThree = true;
	}

	public void Wrong(){
		anim.SetBool ("Opendoor",false);
		BtnOne = false;
		BtnTwo = false;
		BtnThree = false;
	}

//	public void OpenDoor(){
//		anim.SetBool ("Opendoor",true);
//	}
//
//	public void CloseDoor(){
//		anim.SetBool ("Opendoor",false);
//	}
}
