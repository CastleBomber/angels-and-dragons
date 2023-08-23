using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * VR Player Rig has Climber Script
 * 
 * Left/ Right hand have XR Controller Script that references 
 * Controller Node: L/R Hand
 * Select Usage: Grip
 * 
 */
public class Climber : MonoBehaviour
{
    private CharacterController character;
    public static XRController climbingHand;
    private ContinuousMovement continuousMovement;

    void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMovement = GetComponent<ContinuousMovement>();
    }

    void FixedUpdate()
    {
		if (climbingHand)
		{
            continuousMovement.enabled = false;  // !!!!!!!!!!
            Climb();
        }
		else
		{
            continuousMovement.enabled = true;
        }
    }

    // Climbing Computations
    void Climb()
	{
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).
            TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        character.Move(transform.rotation * -velocity * Time.fixedDeltaTime);
    }     
}
