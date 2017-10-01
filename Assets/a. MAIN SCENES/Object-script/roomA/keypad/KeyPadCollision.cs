using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPadCollision : MonoBehaviour {

    public bool KeycardOpen = false;
	private int deadcount =2;
    public AudioClip CorrectSound;
    public AudioClip WrongSound;
    public AudioClip ErrorWarning;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public void Start () {
        audio = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (KeycardOpen)
        {
            KeycardOpen = true;
        }
        if (!KeycardOpen)
        {
            KeycardOpen = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowCard"))
        {
            KeycardOpen = true;
            audio.PlayOneShot(CorrectSound,Volume);
            other.gameObject.SetActive(false);
            //SceneManager.LoadScene("Room2A");
            StartCoroutine(MyMethod());
        }
        if (other.gameObject.CompareTag("WrongCard"))
        {
            deadcount -= 1;
            other.gameObject.SetActive(false);
            audio.PlayOneShot(WrongSound, Volume);
            StartCoroutine(ErrorSound());
        }
        if(deadcount == 0)
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Room2A");
    }
    IEnumerator ErrorSound()
    {
        yield return new WaitForSeconds(1);
        audio.PlayOneShot(ErrorWarning, Volume);
    }
}
