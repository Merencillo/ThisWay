using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject KeypadToOpenDoor;

    private KeyPadCollision _KeyPadCollision;
    private bool BooleanOpenDoorValue = false;
    public bool DoorOpen;
    private Animator anim;
    // Use this for initialization
    public void Start () {
        _KeyPadCollision = KeypadToOpenDoor.GetComponent<KeyPadCollision>();
       bool _KeycardOpen = _KeyPadCollision.KeycardOpen;
    }
	
	// Update is called once per frame
	public void Update () {
        _KeyPadCollision.Update();
        bool _KeycardOpen = _KeyPadCollision.KeycardOpen;
        //print("is ScriptOpenDoor get value from scrpit KeyPadCollision? KeycardOpen" + _KeycardOpen);
        anim = GetComponent<Animator>();
        if (_KeycardOpen)
        {
            DoorOpen = true;
            anim.SetBool("DoorOpen", true);
           // print("DoorOpen" + DoorOpen);
        }
        if (!_KeycardOpen)
        {
            anim.SetBool("DoorOpen", false);
            //print("DoorOpen" + DoorOpen);
            DoorOpen = false;
        }
    }
}
