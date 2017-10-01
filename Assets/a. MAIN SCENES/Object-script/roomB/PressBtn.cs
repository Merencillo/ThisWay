using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine;

public class PressBtn : MonoBehaviour {

    private bool pressed = false;
    public OVRInput.Controller controller;
    public float pressRadius;
    public LayerMask pressMask1;
    public LayerMask pressMask2;
    public LayerMask pressMask3;
    public LayerMask pressMask4;
    public LayerMask pressMask5;
    private GameObject pressObject;
    private bool pressing;

    private Quaternion lastRotation, currentRotation;

    public bool btnObject1 = false;
    public bool btnObject2 = false;
    public bool btnObject3 = false;
    public bool btnObject4 = false;
    public bool btnObject5 = false;

    public void PressingObjectOne()
    {
        //Debug.Log(Time.time);

        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask1);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject1 = true;
         }

    }
    public void PressingObjectTwo()
    {
        //Debug.Log(Time.time);

        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask2);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject2 = true;
        }

    }
    public void PressingObjectThree()
    {
        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask3);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject3 = true;
        }

    }
    public void PressingObjectFour()
    {
        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask4);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject4 = true;
        }

    }
    public void PressingObjectFive()
    {
        pressing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, pressRadius, transform.forward, 0f, pressMask5);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            pressObject = hits[closestHit].transform.gameObject;
            pressObject.GetComponent<Rigidbody>().isKinematic = true;
            btnObject5 = true;
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
            btnObject1 = false;
            btnObject2 = false;
            btnObject3 = false;
            btnObject4 = false;
            btnObject5 = false;
        }
    }
    public void Update()
    {
        btnObject1 = false;
        btnObject2 = false;
        btnObject3 = false;
        btnObject4 = false;
        btnObject5 = false;
        if (pressObject != null)
        {
            lastRotation = currentRotation;
            currentRotation = pressObject.transform.rotation;
        }
     
        if (!pressing && Input.GetButtonDown("Fire1")) PressingObjectOne();
        if (!pressing && Input.GetButtonDown("Fire1")) PressingObjectTwo();
        if (!pressing && Input.GetButtonDown("Fire1")) PressingObjectThree();
        if (!pressing && Input.GetButtonDown("Fire1")) PressingObjectFour();
        if (!pressing && Input.GetButtonDown("Fire1")) PressingObjectFive();
        if (pressing && Input.GetButtonUp("Fire1")) LeaveObject();

        if (!pressing && Input.GetButtonDown("Jump")) PressingObjectOne();
        if (!pressing && Input.GetButtonDown("Jump")) PressingObjectTwo();
        if (!pressing && Input.GetButtonDown("Jump")) PressingObjectThree();
        if (!pressing && Input.GetButtonDown("Jump")) PressingObjectFour();
        if (!pressing && Input.GetButtonDown("Jump")) PressingObjectFive();
        if (pressing && Input.GetButtonUp("Jump")) LeaveObject();
    }
}
