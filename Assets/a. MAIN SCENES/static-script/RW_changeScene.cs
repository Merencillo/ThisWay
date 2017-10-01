using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RW_changeScene : MonoBehaviour {
    public Button nextText;

    void Start () {
        nextText = nextText.GetComponent<Button>();

    }

    public void changeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}
