using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadLight : MonoBehaviour {
    private Light sceneLight;
    public GameObject keypad;
    private KeyPadCollision _KeyPadCollision;
    private bool _KeycardOpen;

    void Start () {
        sceneLight.color = new Color(255,0, 0);
        _KeyPadCollision = keypad.GetComponent<KeyPadCollision>();
    }
	
	void Update () {
        _KeyPadCollision.Update();
        _KeycardOpen = _KeyPadCollision.KeycardOpen;
        print(" _KeycardOpen is " + _KeycardOpen);
	}
}
