/**
 * Script built using ChatGPT
 * Seems appropriate, was about to fully implement
 * until I realized the next video in the VR series goes over
 * how to solve both Hands matching when grabbing objects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// Deals with L/R Hand Attach points to be the same
public class HandsGrabMatchChatGPT : XRGrabInteractable
{
    public GameObject leftHandAttachPoint;
    public GameObject rightHandAttachPoint;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        // Check if the interactor is an XR direct interactor
        if(args.interactorObject is XRDirectInteractor directInteractor)
        {
            // Get the hand type of the interactor
            XRController controller = directInteractor.GetComponent<XRController>();
            if(controller != null)
            {
                if(controller.controllerNode == UnityEngine.XR.XRNode.LeftHand)
                {
                    // Attach to left hand attach point
                    AttachToHand(leftHandAttachPoint);
                }
                else if (controller.controllerNode == UnityEngine.XR.XRNode.RightHand)
                {
					// Attach to right hand attach point

					AttachToHand(rightHandAttachPoint);
                }
            }
        }
    }

    private void AttachToHand(GameObject attachPoint)
    {
        if(attachPoint != null)
        {
            transform.SetParent(attachPoint.transform, false);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }
    }
}
