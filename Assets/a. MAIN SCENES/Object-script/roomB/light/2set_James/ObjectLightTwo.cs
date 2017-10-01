using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLightTwo : MonoBehaviour {
    public GameObject Door;
    public GameObject Button;
    private OpenDoor _OpenDoor;
    private AnimateBtnTwo _AnimateBtn;
    private bool _DoorOpen = false;
    private bool _boolBtnAnimated = false;
    private Light sceneLight;

    public float Seconds;

    void Start()
    {
        sceneLight = GetComponent<Light>();
        _OpenDoor = Door.GetComponent<OpenDoor>();
        _AnimateBtn = Button.GetComponent<AnimateBtnTwo>();
    }

    void Update()
    {
        _OpenDoor.Update();
        _AnimateBtn.Update();
        _DoorOpen = _OpenDoor.DoorOpen;
        _boolBtnAnimated = _AnimateBtn.boolBtnAnimated;
        //print("Room B Lights: DoorOpen is " + _DoorOpen);
        if (_DoorOpen)
        {
            if (Seconds > 0)
            {
                Seconds -= Time.deltaTime;
            }
            else
            {
                sceneLight.intensity = 8;
            }
        }
        if (_boolBtnAnimated)
        {
            sceneLight.intensity = 0;
        }

    }
}
