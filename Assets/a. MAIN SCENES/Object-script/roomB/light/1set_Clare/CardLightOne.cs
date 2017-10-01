using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLightOne : MonoBehaviour {
    public GameObject Button;
    private AnimateBtn _AnimateBtn;
    private bool _boolBtnAnimated = false;
    private Light sceneLight;

    void Start () {
        sceneLight = GetComponent<Light>();
        _AnimateBtn = Button.GetComponent<AnimateBtn>();
    }
	
	void Update () {
        _AnimateBtn.Update();
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;
        if (_boolBtnAnimated)
        {
            sceneLight.intensity = 2;
        }
    }
}
