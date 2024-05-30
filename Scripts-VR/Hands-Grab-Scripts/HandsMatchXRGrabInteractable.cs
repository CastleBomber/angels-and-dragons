using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// Deals with L/R Hand Attach points to be the same
// Attached to a grabbable object (Lightsaber)
// L/R Grab Ray control distance grab
// XRGrabInteractableTwoHands{}
public class HandsMatchXRGrabInteractable : XRGrabInteractable
{
	public Transform leftAttachTransform;
	public Transform rightAttachTransform;

	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
		if (args.interactorObject.transform.CompareTag("LeftHand"))
		{
			attachTransform = leftAttachTransform;
		}
		else if (args.interactorObject.transform.CompareTag("RightHand"))
		{
			attachTransform = rightAttachTransform;
		}

		base.OnSelectEntered(args);
	}
}
