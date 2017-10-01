using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroneDead : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           other.gameObject.SetActive(false);
           SceneManager.LoadScene("DeadScene");
        }
    }
}
