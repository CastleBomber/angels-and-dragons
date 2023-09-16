using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * VR Flying Script
 * 
 * Left/ Right hand have XR Controller Script that references 
 * Controller Node: L/R Hand
 * Activate Usage: Trigger
 */
public class Fly : XRBaseInteractable
{
	private XRRig rig;
	private CharacterController character;
	public XRController leftController;
	public XRController rightController;
	public float flyingSpeed;
	public float activationThreshold; 

	void Start()
	{
		character = GetComponent<CharacterController>();
		rig = GetComponent<XRRig>();
	}

	private void FixedUpdate()
	{
		buttonFlightListener();
	}

	/**
	 * Fly up when triggers jointly pressed
	 * Fly down when grips jointly pressed
	 */
	void buttonFlightListener()
	{
		// Fly up
		if (CheckTriggers())
		{
			character.Move(Vector3.up);
		}

		// Fly down
		if (CheckGrips())
		{
			character.Move(Vector3.down);
		}
	}

	/**
	 * Checks that both triggers of controllers are pressed
	 * If true, player flys down
	 */
	public bool CheckTriggers()
	{
		InputDevices.GetDeviceAtXRNode(leftController.controllerNode).
			TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerLeft);

		InputDevices.GetDeviceAtXRNode(rightController.controllerNode).
			TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerRight);


		if (triggerLeft && triggerRight)
		{
			return true;
		}

		return false;
	}

	/**
	 * Checks that both grips of controllers are pressed
	 * If true, player flys down
	 */
	public bool CheckGrips()
	{
		InputDevices.GetDeviceAtXRNode(leftController.controllerNode).
			TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool gripLeft);

		InputDevices.GetDeviceAtXRNode(rightController.controllerNode).
			TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool gripRight);

		if (gripLeft && gripRight)
		{
			return true;
		}

		return false;
	}
}
