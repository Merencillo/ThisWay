using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrongHandleObject5 : MonoBehaviour {
    public GameObject handR;
    public GameObject rightMsg;
    private MoveWrongHandle5 _MoveWrongHandle5;
    private MoveHandle _GetRightMsg;

    public bool errorCount_yellow;
    private bool booleanScriptMoveObejct = false;
    public bool Move;
    private bool OpenVentBool = false;
    public bool lightActive_Yellow = false;
    private Animator anim;

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public void Start () {
        _MoveWrongHandle5 = handR.GetComponent<MoveWrongHandle5>();
        _GetRightMsg = rightMsg.GetComponent<MoveHandle>();
        audio = GetComponent<AudioSource>();
    }
	
	public void Update () {
        _MoveWrongHandle5.MovingWrongObject();
        _GetRightMsg.Update();
        booleanScriptMoveObejct = _MoveWrongHandle5.wronghandleObject5;
        OpenVentBool = _GetRightMsg.OpenVentBool;

        anim = GetComponent<Animator>();
        if (booleanScriptMoveObejct)
        {
            anim.SetBool("Move", true);
            audio.Play();
            alreadyPlayed = true;
            errorCount_yellow = true;
            lightActive_Yellow = true;
        }
        if (!booleanScriptMoveObejct)
        {
            anim.SetBool("Move", false);
        }
        if (OpenVentBool)
        {
            audio.Stop();
            lightActive_Yellow = false;
        }
    }
}
