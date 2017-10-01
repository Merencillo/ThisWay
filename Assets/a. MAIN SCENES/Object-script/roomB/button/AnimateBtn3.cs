using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBtn3 : MonoBehaviour {
    public GameObject handR;
    public GameObject handL;
    private PressBtn _PressBtn;
    private PressBtn _PressBtnL;
    private bool booleanScriptPressObejct = false;
    private bool booleanScriptPressObejctL = false;

    public bool ButtonPressed;
    public bool ButtonPressedL;
    public bool boolBtnAnimated;
    private Animator anim;

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public void Start () {
        _PressBtn = handR.GetComponent<PressBtn>();
        _PressBtnL = handL.GetComponent<PressBtn>();

        audio = GetComponent<AudioSource>();
        if (!alreadyPlayed)
        {
            audio.Stop();
        }
    }
	
	public void Update () {
        _PressBtn.PressingObjectThree();
        _PressBtnL.PressingObjectThree();
        booleanScriptPressObejct = _PressBtn.btnObject3;
        booleanScriptPressObejctL = _PressBtnL.btnObject3;

        anim = GetComponent<Animator>();
        if (booleanScriptPressObejct)
        {
            anim.SetBool("ButtonPressed", true);
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
            boolBtnAnimated = true;

        }

        if (!booleanScriptPressObejct)
        {
            anim.SetBool("ButtonPressed", false);

        }
        if (booleanScriptPressObejctL)
        {
            anim.SetBool("ButtonPressedL", true);
            print("Left Press is " + ButtonPressedL);
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
            boolBtnAnimated = true;
        }

        if (!booleanScriptPressObejctL)
        {
            anim.SetBool("ButtonPressedL", false);

        }
    }
}
