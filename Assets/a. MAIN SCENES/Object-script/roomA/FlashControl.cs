using UnityEngine;
using System.Collections;

public class FlashControl : MonoBehaviour {
    public GameObject wrongHandle_red;
    public GameObject wrongHandle_blue;
    public GameObject wrongHandle_orange;
    public GameObject wrongHandle_yellow;
    private MoveWrongHandleObject2 _wrongHandleRed;
    private MoveWrongHandle _wrongHandleBlue;
    private MoveWrongHandleObject4 _wrongHandleOrange;
    private MoveWrongHandleObject5 _wrongHandleYellow;
    private bool _lightActive = false;
    private bool _lightActive_red = false;
    private bool _lightActive_orange = false;
    private bool _lightActive_yellow = false;

    private float counterFlash = 0;
    private float counterMove = 0;
    private Light sceneLight;

    public bool flashEnabled;
    public bool moveEnabled;

	void Start () {
        sceneLight = GetComponent<Light>();
        _wrongHandleRed = wrongHandle_red.GetComponent<MoveWrongHandleObject2>();
        _wrongHandleBlue = wrongHandle_blue.GetComponent<MoveWrongHandle>();
        _wrongHandleOrange = wrongHandle_orange.GetComponent<MoveWrongHandleObject4>();
        _wrongHandleYellow = wrongHandle_yellow.GetComponent<MoveWrongHandleObject5>();
    }

	void Update () {
        _wrongHandleRed.Update();
        _wrongHandleBlue.Update();
        _wrongHandleOrange.Update();
        _wrongHandleYellow.Update();
        _lightActive_red = _wrongHandleRed.lightActive_red;
        _lightActive = _wrongHandleBlue.lightActive;
        _lightActive_orange = _wrongHandleOrange.lightActive_Orange;
        _lightActive_yellow = _wrongHandleYellow.lightActive_Yellow;


        if (_lightActive || _lightActive_red || _lightActive_orange || _lightActive_yellow)
        {
            flashEnabled = true;
            moveEnabled = true;
        }
        else
        {
            flashEnabled = false;
            moveEnabled = false;
        }

        if (flashEnabled)
        {
            counterFlash += Time.deltaTime;
            sceneLight.intensity = (Mathf.Sin(counterFlash * 20f) + 1f) * 3;
        }
        if (moveEnabled)
        {
            counterMove += Time.deltaTime;
            sceneLight.transform.localRotation = Quaternion.AngleAxis(counterMove * 360, Vector3.forward) * Quaternion.AngleAxis(15, Vector3.left);

        }
        if (!flashEnabled)
        {
            sceneLight.intensity = 0;
        }
        if (!moveEnabled)
        {
            counterMove = 0;
        }
    }
}
