using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCard3 : MonoBehaviour {
    public GameObject Button;
    public GameObject card;
    private AnimateBtn3 _AnimateBtn;
    private bool _boolBtnAnimated = false;
    private Animator anim;
    public bool CardHide;
    private bool CardStatus;

    void Start()
    {
        _AnimateBtn = Button.GetComponent<AnimateBtn3>();
    }

    void Update()
    {
        _AnimateBtn.Update();
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;
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
