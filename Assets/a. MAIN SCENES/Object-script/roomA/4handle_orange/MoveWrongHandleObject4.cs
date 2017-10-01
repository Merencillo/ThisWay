using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrongHandleObject4 : MonoBehaviour {
    public GameObject handR;
    public GameObject rightMsg;
    private MoveWrongHandle4 _MoveWrongHandle4;
    private MoveHandle _GetRightMsg;

    public bool errorCount_orange;
    private bool booleanScriptMoveObejct = false;
    public bool Move;
    private bool OpenVentBool = false;
    public bool lightActive_Orange = false;
    private Animator anim;

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public void Start () {
        _MoveWrongHandle4 = handR.GetComponent<MoveWrongHandle4>();
        _GetRightMsg = rightMsg.GetComponent<MoveHandle>();
        audio = GetComponent<AudioSource>();
    }
	
	public void Update () {
        _MoveWrongHandle4.MovingWrongObject();
        _GetRightMsg.Update();
        booleanScriptMoveObejct = _MoveWrongHandle4.wronghandleObject4;
        OpenVentBool = _GetRightMsg.OpenVentBool;

        anim = GetComponent<Animator>();
        if (booleanScriptMoveObejct)
        {
            anim.SetBool("Move", true);
            audio.Play();
            alreadyPlayed = true;
            errorCount_orange = true;
            lightActive_Orange = true;
        }
        if (!booleanScriptMoveObejct)
        {
            anim.SetBool("Move", false);
        }
        if (OpenVentBool)
        {
            audio.Stop();
            lightActive_Orange = false;
        }
    }
}
