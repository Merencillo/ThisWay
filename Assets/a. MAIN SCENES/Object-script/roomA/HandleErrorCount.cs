using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleErrorCount : MonoBehaviour {
    public GameObject wrongHandle_red;
    public GameObject wrongHandle_blue;
    public GameObject wrongHandle_orange;
    public GameObject WrongHandle_yellow;
    private MoveWrongHandleObject2 _wrongHandleRed;
    private MoveWrongHandle _wrongHandleBlue;
    private MoveWrongHandleObject4 _wrongHandleOrange;
    private MoveWrongHandleObject5 _wrongHandleYellow;

    //public GameObject fadingGM;

    private bool dead = false;
    private bool _errorCount_red = false;
    private bool _errorCount_blue = false;
    private bool _errorCount_orange = false;
    private bool _errorCount_yellow = false;

    void Start () {
        _wrongHandleRed = wrongHandle_red.GetComponent<MoveWrongHandleObject2>();
        _wrongHandleBlue = wrongHandle_blue.GetComponent<MoveWrongHandle>();
        _wrongHandleOrange = wrongHandle_orange.GetComponent<MoveWrongHandleObject4>();
        _wrongHandleYellow = WrongHandle_yellow.GetComponent<MoveWrongHandleObject5>();
    }

    void Update () {
        _wrongHandleRed.Update();
        _wrongHandleBlue.Update();
        _wrongHandleOrange.Update();
        _wrongHandleYellow.Update();
        _errorCount_red = _wrongHandleRed.errorCount_red;
        _errorCount_blue = _wrongHandleBlue.errorCount_blue;
        _errorCount_orange = _wrongHandleOrange.errorCount_orange;
        _errorCount_yellow = _wrongHandleYellow.errorCount_yellow;

        //wrongHandle_red with other handles
        if (_errorCount_red && _errorCount_blue )
        {
            SceneManager.LoadScene("DeadScene");
        }
        if (_errorCount_red && _errorCount_orange)
        {
            SceneManager.LoadScene("DeadScene");
        }
        if (_errorCount_red && _errorCount_yellow)
        {
            SceneManager.LoadScene("DeadScene");
        }
        //wrongHandle_blue with other handles
        if (_errorCount_blue && _errorCount_orange)
        {
            SceneManager.LoadScene("DeadScene");
        }
        if (_errorCount_blue && _errorCount_yellow)
        {
            SceneManager.LoadScene("DeadScene");
        }
        //wrongHandle_orange with other handles
        if (_errorCount_orange && _errorCount_yellow)
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
       
}
