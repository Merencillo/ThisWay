using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {
    public float Seconds = 59;
    public float Minutes = 0;
    //public Text countdownText;
    public Text countdownMin;
    public Text countdownSec;

    void Start () {
		
	}
	
	void Update () {
		if (Seconds <= 0)
        {
            Seconds = 59;
            if(Minutes >= 1)
            {
                Minutes--;
            }
            else
            {
                Minutes = 0;
                Seconds = 0;
                //countdownText.text = "Time Remaining " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
                countdownMin.text = Minutes.ToString("f0");
                countdownSec.text = Seconds.ToString("f0");
            }
        }
        else
        {
            Seconds -= Time.deltaTime;
        }
        if (Mathf.Round(Seconds)<=9)
        {
            //countdownText.text = "Time Remaining " + Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
            countdownMin.text = Minutes.ToString("f0");
            countdownSec.text = "0" + Seconds.ToString("f0");
        }
        else
        {
            //countdownText.text = "Time Remaining " + Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
            countdownMin.text = Minutes.ToString("f0");
            countdownSec.text = Seconds.ToString("f0");
        }
        if (Minutes<=0  && Seconds<=0)
        {
            SceneManager.LoadScene("DeadScene");    
        }
    }
}
