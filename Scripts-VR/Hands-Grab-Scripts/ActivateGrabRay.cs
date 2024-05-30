using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    public GameObject leftGrabRay; // Force grab an object
    public GameObject rightGrabRay;

    public XRDirectInteractor leftDirectGrab; // Literally pick up an object with hands
    public XRDirectInteractor rightDirectGrab;

    void Update()
    {
        // AI Assisted: using selectTarget (interactlesSelect deprecated?)
        leftGrabRay.SetActive(leftDirectGrab.selectTarget == null);
		rightGrabRay.SetActive(rightDirectGrab.selectTarget == null);
	}
}
