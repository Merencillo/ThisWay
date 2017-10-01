using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionTextRoom2 : MonoBehaviour {
    public Text targetText;
    public Text desText;
    public GameObject correctBtn;
    private AnimateBtn _AnimateBtn;
    public bool _boolBtnAnimated = false;

    void Start () {
        _AnimateBtn = correctBtn.GetComponent<AnimateBtn>();
    }
	
	void Update () {
        _AnimateBtn.Update();
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;
        if (!_boolBtnAnimated)
        {
            targetText.text = "Morse Code";
            desText.text = "Tell your partner what Morse Code you see and let them decode for you.";
        }
        if (_boolBtnAnimated)
        {
            targetText.text = "Key Card";
            desText.text = "Find the correct key card in the glass box and use it to touch key pad to unlock the door.";
        }

    }
}
