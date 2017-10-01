using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCard : MonoBehaviour {
    public GameObject LockBox;
    public GameObject Button;
    public GameObject card;
    private LockBox _LockBox;
    private AnimateBtn _AnimateBtn;
    private bool _boolBtnAnimated = false;
    private bool _booleanScriptPressObejct = false;
    private bool _booleanScriptPressObejctL = false;
    private Animator anim;
    public bool CardHide;
    private bool CardStatus;

    void Start () {
        _LockBox = LockBox.GetComponent<LockBox>();
        _AnimateBtn = Button.GetComponent<AnimateBtn>();
    }
	
	void Update () {
        _LockBox.Update();
        _AnimateBtn.Update();
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;
        _booleanScriptPressObejct = _LockBox.booleanScriptPressObejct;
        _booleanScriptPressObejctL = _LockBox.booleanScriptPressObejctL;
        anim = GetComponent<Animator>();

        if (!_boolBtnAnimated)
        {
            CardStatus = false;
            anim.SetBool("CardHide", true);

        }
        if (_boolBtnAnimated)
        {
            card.SetActive(true);
            if (!CardStatus)
            {
                anim.SetBool("CardHide", false);
            }
           
        }        
    }
}
