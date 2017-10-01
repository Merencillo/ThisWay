using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrongHandleObject2 : MonoBehaviour {
    public GameObject handR;
    public GameObject rightMsg;
    private MoveWrongHandle2 _MoveWrongHandle2;
    private MoveHandle _GetRightMsg;

    public bool errorCount_red;
    private bool booleanScriptMoveObejct = false;
    public bool Move;
    private bool OpenVentBool = false;
    public bool lightActive_red = false;
    private Animator anim;

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    void Start()
    {
        _MoveWrongHandle2 = handR.GetComponent<MoveWrongHandle2>();
        _GetRightMsg = rightMsg.GetComponent<MoveHandle>();
        audio = GetComponent<AudioSource>();
    }

    public void Update()
    {
        _MoveWrongHandle2.MovingWrongObject();
        _GetRightMsg.Update();
        booleanScriptMoveObejct = _MoveWrongHandle2.wronghandleObject2;
        OpenVentBool = _GetRightMsg.OpenVentBool;

        anim = GetComponent<Animator>();
        if (booleanScriptMoveObejct)
        {
            anim.SetBool("Move", true);
            audio.Play();
            alreadyPlayed = true;
            errorCount_red = true;
            lightActive_red = true;
        }
        if (!booleanScriptMoveObejct)
        {
            anim.SetBool("Move", false);
        }
        if (OpenVentBool)
        {
            audio.Stop();
            lightActive_red = false;
        }
    }
}
