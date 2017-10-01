using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandle : MonoBehaviour {

    public GameObject handR;
    public GameObject handL;

    private MoveObject _MoveObject;
    private MoveObject _MoveObjectL;
    public bool booleanScriptMoveObejct=false;
    public bool booleanScriptMoveObejctL = false;

    public bool Move;
    private Animator anim;
    public bool OpenVentBool;

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    void Start () {

        _MoveObject = handR.GetComponent<MoveObject>();
        _MoveObjectL = handL.GetComponent<MoveObject>();
            
        audio = GetComponent<AudioSource>();
        if (!alreadyPlayed)
        {
            audio.Stop();
        }
    }
	
	public void Update () {
        
        _MoveObject.MovingObject();
        _MoveObjectL.MovingObject();
        booleanScriptMoveObejct = _MoveObject.handleObject;
        booleanScriptMoveObejctL = _MoveObjectL.handleObject;

        anim = GetComponent<Animator>();
        if (booleanScriptMoveObejct)
        {
            anim.SetBool("Move", true);
            //print("booleanScriptMoveObject is " + booleanScriptMoveObejct);
            OpenVentBool = true;
            if (OpenVentBool)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
                alreadyPlayed = true;
            }
        }
        if (!booleanScriptMoveObejct)
        {            
            anim.SetBool("Move", false);
            //print("booleanScriptMoveObject is " + booleanScriptMoveObejct);
            OpenVentBool = false;
        }
        print("UI TEST is booleanScriptMoveObejct" + booleanScriptMoveObejct);
    }
}
