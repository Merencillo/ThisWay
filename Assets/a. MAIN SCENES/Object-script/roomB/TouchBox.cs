using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine;

public class TouchBox : MonoBehaviour {
    private bool pressed = false;
    public OVRInput.Controller controller;
    public float pressRadius;
    public LayerMask pressMask;
    private GameObject pressObject;
    private bool pressing;

    private Quaternion lastRotation, currentRotation;

    public bool btnObject = false;

    public void PressingObject()
    {
        //Debug.Log(Time.time);

        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject = true;
        }

    }

    public void LeaveObject()
    {
        pressing = false;
        if (pressObject != null)
        {
            pressObject.transform.parent = null;
            pressObject.GetComponent<Rigidbody>().isKinematic = false;
            pressObject = null;
            btnObject = false;
        }
    }
    public void Update()
    {
        btnObject = false;
        if (pressObject != null)
        {
            lastRotation = currentRotation;
            currentRotation = pressObject.transform.rotation;
        }

        if (!pressing && Input.GetButtonDown("Fire1")) PressingObject();
        if (pressing && Input.GetButtonUp("Fire1")) LeaveObject();
        if (!pressing && Input.GetButtonDown("Jump")) PressingObject();
        if (pressing && Input.GetButtonUp("Jump")) LeaveObject();
    }
}
