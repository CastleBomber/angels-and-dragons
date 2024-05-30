using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * XR Controller Script (Action-based)
 */
public class Climber : MonoBehaviour
{
    private CharacterController character;
    public InputActionReference leftClimbingAction;
    public InputActionReference rightClimbingAction;
	public int maxClimbSpeed;
    private bool isClimbing;

    void Start()
    {
        character = GetComponent<CharacterController>();
		
        // Subscribe to left and right climbing actions
        leftClimbingAction.action.performed += context => OnClimbPerformed(context, leftClimbingAction);
		leftClimbingAction.action.canceled += context => OnClimbCanceled(context, leftClimbingAction);

		rightClimbingAction.action.performed += context => OnClimbPerformed(context, rightClimbingAction);
		rightClimbingAction.action.canceled += context => OnClimbCanceled(context, rightClimbingAction);
	}

    void OnClimbPerformed(InputAction.CallbackContext context, InputActionReference actionReference)
    {
        isClimbing = true;
    }

	void OnClimbCanceled(InputAction.CallbackContext context, InputActionReference actionReference)
	{
		isClimbing = false;
	}

	void FixedUpdate()
    {
        // If climbing, we are not able to run/fly
		if (isClimbing)
		{
			Climb();
		}
		else
		{
        }
    }

	/**
	 * Climbing Computations
	 * A velocity is produced from the climbingHand
	 * The -velocity indicates a upward movement as the hand goes down
	 */
	void Climb()
	{

		float gripValue = leftClimbingAction.action.ReadValue<float>();
		float climbSpeed = gripValue * maxClimbSpeed;
		Vector3 climbDirection = transform.up * climbSpeed;

		character.Move(-climbDirection * Time.fixedDeltaTime);

        Debug.Log("Climber.cs Climb()");

	}

	public void StartClimbing()
    {
        isClimbing = true;
    }

    public void StopClimbing()
    {
        isClimbing = false;
    }

    void OnDestroy()
    {
		// Unsubscribe from left and right climbing actions
		leftClimbingAction.action.performed -= context => OnClimbPerformed(context, leftClimbingAction);
		leftClimbingAction.action.canceled -= context => OnClimbCanceled(context, leftClimbingAction);

		rightClimbingAction.action.performed -= context => OnClimbPerformed(context, rightClimbingAction);
		rightClimbingAction.action.canceled -= context => OnClimbCanceled(context, rightClimbingAction);
	}
}
