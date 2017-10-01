﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrongHandle2 : MonoBehaviour {
    public OVRInput.Controller controller;
    public string buttonName;
    public float grabRadius;
    public LayerMask grabMask;
    private GameObject grabbedObject;
    private bool grabbing;

    private Quaternion lastRotation, currentRotation;

    public bool wronghandleObject2 = false;




    public void MovingWrongObject()
    {
        //Debug.Log(Time.time);

        grabbing = true;
        RaycastHit[] hits;
        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);

        if (hits.Length > 0)
        {
            int closestHit = 0;
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closestHit].distance) closestHit = i;
            }
            grabbedObject = hits[closestHit].transform.gameObject;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
            wronghandleObject2 = true;
            
        }

    }

    public void DropObject()
    {
        grabbing = false;

        if (grabbedObject != null)
        {
            grabbedObject.transform.parent = null;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObject = null;
            wronghandleObject2 = false;
        }
    }

    Vector3 GetAngularVelocity()
    {
        Quaternion deltaRotation = currentRotation * Quaternion.Inverse(lastRotation);
        return new Vector3(Mathf.DeltaAngle(0, deltaRotation.eulerAngles.x), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.y), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.z));
    }

    public void Update()
    {
        wronghandleObject2 = false;
        if (grabbedObject != null)
        {
            lastRotation = currentRotation;
            currentRotation = grabbedObject.transform.rotation;
        }

        if (!grabbing && Input.GetAxis(buttonName) == 1) MovingWrongObject();
        if (grabbing && Input.GetAxis(buttonName) < 1) DropObject();

    }
}
