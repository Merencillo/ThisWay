using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPadCollisionWin : MonoBehaviour {
    public bool KeycardOpen = false;
    private int deadcount = 2;
    public AudioClip CorrectSound;
    public AudioClip WrongSound;
    public AudioClip ErrorWarning;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    private float winCount = 2;

    public void Start()
    {
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
            audio.PlayOneShot(CorrectSound, Volume);
            other.gameObject.SetActive(false);
            //winCount -= 1;
            KeycardOpen = true;
            StartCoroutine(MyMethod());
        }
        if (other.gameObject.CompareTag("WrongCard"))
        {
            deadcount -= 1;
            other.gameObject.SetActive(false);
            audio.PlayOneShot(WrongSound, Volume);
            //audio.PlayOneShot(ErrorWarning, Volume);
            StartCoroutine(ErrorSound());
        }
        //if (winCount == 0)
        //{
            //KeycardOpen = true;
            //StartCoroutine(MyMethod());
        //}
        if (deadcount == 0)
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("WinScene");
    }
    IEnumerator ErrorSound()
    {
        yield return new WaitForSeconds(1);
        audio.PlayOneShot(ErrorWarning, Volume);
    }
}
