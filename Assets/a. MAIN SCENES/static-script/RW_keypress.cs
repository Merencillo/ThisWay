using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RW_keypress : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Room2A -multiplayer");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Room2A");
        }
        Debug.Log("Space key was pressed.");

        if (Input.GetKeyUp(KeyCode.Space))
            Debug.Log("Space key was released.");
    }
}
