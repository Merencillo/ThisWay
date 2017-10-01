using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVent : MonoBehaviour {

    public GameObject HandleToOpenVent;

    private MoveHandle _MoveHandle;
    private bool BooleanOpenVentValue = false;

    public bool VentOpen;
    private Animator anim;

   

    // Use this for initialization
    void Start () {

        _MoveHandle = HandleToOpenVent.GetComponent<MoveHandle>();
        print("VentOpen " + VentOpen);
    }
	
	// Update is called once per frame
	void Update () {
        _MoveHandle.Update();
        BooleanOpenVentValue = _MoveHandle.OpenVentBool;
        //print(" BooleanOpenVentValue" + BooleanOpenVentValue);
        anim = GetComponent<Animator>();
        if (BooleanOpenVentValue)
        {
            anim.SetBool("VentOpen", true);
        }
        if (!BooleanOpenVentValue)
        {
            anim.SetBool("VentOpen", false);
        }
    }

   
}
