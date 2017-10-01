using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionText : MonoBehaviour {
    public Text targetText;
    public Text desText;
    public GameObject correctLever;
    private MoveHandle _MoveHandle;
    private bool BooleanOpenVentValue = false;
    private bool changeText;

    void Start () {
        _MoveHandle = correctLever.GetComponent<MoveHandle>();
        print("Test UI interactive" + BooleanOpenVentValue);
    }

	void Update () {
        _MoveHandle.Update();
        BooleanOpenVentValue = _MoveHandle.booleanScriptMoveObejct;
        print("Test UI interactive" + BooleanOpenVentValue);
        if (!BooleanOpenVentValue)
        {
            changeText = true;
            targetText.text = "Body Signs";
            desText.text = "Find the body signs. Tell your partner what color of people you see and their position of arms";
        }
        if (changeText)
        {
            targetText.text = "Key Card";
            desText.text = "Find the correct key card on the desk and use it to touch key pad to unlock the door.";
        }
    }
}
