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
		base.OnSelectEntered(interactor);

		if (interactor is XRDirectInteractor)
		{
			Climber.climbingHand = interactor.GetComponent<XRController>();
		}
	}

	protected override void OnSelectExited(XRBaseInteractor interactor)
	{
		base.OnSelectExited(interactor);

		if (interactor is XRDirectInteractor)
		{
			if (Climber.climbingHand && Climber.climbingHand.name == interactor.name)
			{
				Climber.climbingHand = null;
			}
		}
	}
}
