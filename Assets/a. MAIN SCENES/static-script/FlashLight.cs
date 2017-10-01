using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
    private float counterFlash = 0;
    private float counterMove = 0;
    private Light sceneLight;
    public bool flashEnabled;
    public bool moveEnabled;
    
    void Start () {
        sceneLight = GetComponent<Light>();
    }
	
	void Update () {
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
    }
}
