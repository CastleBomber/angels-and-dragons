using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * 
 */
public class Fly : MonoBehaviour
{
	private CharacterController character;
	public InputActionProperty leftTrigger; // New
	public InputActionProperty rightTrigger;
	public InputActionProperty leftGrip;
	public InputActionProperty rightGrip;
	public float flyingSpeed;
	public float activationThreshold;


	void Start()
	{
		character = GetComponent<CharacterController>();
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
		if (leftTrigger.action.ReadValue<float>() > 0.1f && rightTrigger.action.ReadValue<float>() > 0.1f)
		{
			character.Move(Vector3.up);
		}

		if (leftGrip.action.ReadValue<float>() > 0.1f && rightGrip.action.ReadValue<float>() > 0.1f)
		{
			character.Move(Vector3.down);
		}
	}
}
