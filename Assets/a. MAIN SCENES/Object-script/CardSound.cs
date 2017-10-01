using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSound : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Desk"))
        {
            GetComponent<AudioSource>().Play();
        }
        if (other.gameObject.CompareTag("WrongCard"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
