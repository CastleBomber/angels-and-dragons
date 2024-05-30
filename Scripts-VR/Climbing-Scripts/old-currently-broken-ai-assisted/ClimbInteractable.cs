using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * Attached to the individual knobs on the climbing wall
 * Supports climbing feature
 */
public class ClimbInteractable : XRBaseInteractable
{
	protected override void OnSelectEntered(XRBaseInteractor interactor)
	{
		// Select Usgae: Grip
		base.OnSelectEntered(interactor);
		StartClimbing(interactor);
		Debug.Log("Select Entered");
	}

	protected override void OnSelectExited(XRBaseInteractor interactor)
	{
		base.OnSelectExited(interactor);
		StopClimbing(interactor);
		Debug.Log("Select Exited");
	}

	void StartClimbing(XRBaseInteractor interactor)
	{
		if (interactor is XRDirectInteractor)
		{
			Climber climbingScript = interactor.GetComponent<Climber>();
			if (climbingScript != null)
			{
				climbingScript.StartClimbing();
				//climbingScript.OnClimbPerformed();
				Debug.Log("climbingScript.StartClimbing()");
			}
		}
	}

	void StopClimbing(XRBaseInteractor interactor)
	{
		if (interactor is XRDirectInteractor)
		{
			Climber climbingScript = interactor.GetComponent<Climber>();
			if (climbingScript != null)
			{
				climbingScript.StopClimbing();
				//climbingScript.OnClimbCanceled();
			}
		}
	}
}
