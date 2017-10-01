using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBox5 : MonoBehaviour {
    public GameObject handR;
    public GameObject handL;
    public GameObject buttonRoom;
    private TouchBox _TouchBox;
    private TouchBox _TouchBoxL;
    private AnimateBtn5 _AnimateBtn;
    private bool booleanScriptPressObejct = false;
    private bool booleanScriptPressObejctL = false;
    private bool _boolBtnAnimated = false;

    public bool BoxUnlock;
    private bool CloseSound;
    private Animator anim;

    public AudioClip SoundToPlay;
    public AudioClip SoundToDrop;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    
    void Start () {
        _TouchBox = handR.GetComponent<TouchBox>();
        _TouchBoxL = handL.GetComponent<TouchBox>();
        _AnimateBtn = buttonRoom.GetComponent<AnimateBtn5>();

        audio = GetComponent<AudioSource>();
        if (!alreadyPlayed)
        {
            audio.Stop();
        }
    }
	
	void Update () {
        _TouchBox.PressingObject();
        _TouchBoxL.PressingObject();
        _AnimateBtn.Update();
        booleanScriptPressObejct = _TouchBox.btnObject;
        booleanScriptPressObejctL = _TouchBoxL.btnObject;
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;

        anim = GetComponent<Animator>();
        if (booleanScriptPressObejct)
        {
            if (!_boolBtnAnimated)
            {
                audio.PlayOneShot(SoundToPlay, Volume / 10);
                alreadyPlayed = true;
            }
            else
            {
                audio.Stop();
            }
        }

        if (booleanScriptPressObejctL)
        {
            audio.PlayOneShot(SoundToPlay, Volume / 10);
            alreadyPlayed = true;
        }

        if (_boolBtnAnimated)
        {
            anim.SetBool("BoxUnlock", true);

            CloseSound = false;

        }
        if (!_boolBtnAnimated)
        {
            anim.SetBool("BoxUnlock", false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Room2Table"))
        {
            audio.PlayOneShot(SoundToDrop, Volume*2);

        }

    }
}
