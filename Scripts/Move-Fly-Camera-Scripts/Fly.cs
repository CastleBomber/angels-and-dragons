using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Fly : XRBaseInteractable
{
	private XRRig rig;
	private CharacterController character;
	public XRController leftController;
	public XRController rightController;
	public InputHelpers.Button flyUpButtonLeft;
	public InputHelpers.Button flyUpButtonRight;
	public InputHelpers.Button flyDownButtonLeft;
	public InputHelpers.Button flyDownButtonRight;
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

	// Fly up or down when triggers or grips jointly pressed
	void buttonFlightListener()
	{
		// Fly up
		if (CheckIfActivated(leftController, flyUpButtonLeft) 
			&& CheckIfActivated(rightController, flyUpButtonRight))
		{
			character.Move(Vector3.up);
		}

		// Fly down
		if (CheckIfActivated(leftController, flyDownButtonLeft) 
			&& CheckIfActivated(rightController, flyDownButtonRight))
		{
			character.Move(Vector3.down);
		}
	}

	public bool CheckIfActivated(XRController controller, InputHelpers.Button button)
	{
		InputHelpers.IsPressed(controller.inputDevice, button, out bool isActivated, activationThreshold);
		return isActivated;
	}
}
