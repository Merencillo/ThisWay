using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveWrongHandle : MonoBehaviour {

    public GameObject handR;
    public GameObject rightMsg;
    private MoveWrongHandle1 _MoveWrongHandle1;
    private MoveHandle _GetRightMsg;

    private bool booleanScriptMoveObejct = false;
    public bool OpenVentBool = false;
    public bool lightActive =false;
    public bool errorCount_blue;

    public bool Move;
    private Animator anim;
    
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    void Start()
    {
        _MoveWrongHandle1 = handR.GetComponent<MoveWrongHandle1>();
        _GetRightMsg = rightMsg.GetComponent<MoveHandle>();
        
        audio = GetComponent<AudioSource>();
    }

    public void Update()
    {
        _MoveWrongHandle1.MovingWrongObject();
        _GetRightMsg.Update();

        booleanScriptMoveObejct = _MoveWrongHandle1.wronghandleObject;
        OpenVentBool = _GetRightMsg.OpenVentBool;
        //print("errorCount_blue" + errorCount_blue);
        anim = GetComponent<Animator>();
        if (booleanScriptMoveObejct)
        {
            anim.SetBool("Move", true);
            //SceneManager.LoadScene("DeadScene");
            audio.Play();
            alreadyPlayed = true;
            lightActive = true;
            errorCount_blue = true;
            //print("errorCount_blue" + errorCount_blue);
        }
        if (!booleanScriptMoveObejct)
        {
            anim.SetBool("Move", false);            
        }
        if (OpenVentBool)
        {
            audio.Stop();
            lightActive = false;
        }
    }
}
