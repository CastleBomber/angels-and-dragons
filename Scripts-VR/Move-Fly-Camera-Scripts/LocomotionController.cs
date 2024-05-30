using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// XR Controller(Controller-based) OLD
public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold;

    public XRRayInteractor leftRayInteractor;
    public XRRayInteractor rightRayInteractor;

    public bool EnableLeftTeleport { get; set; } = true;
    public bool EnableRightTeleport { get; set; } = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3();
        Vector3 norm = new Vector3();
        int index = 0;
        bool validTarget = false;

		if (leftTeleportRay)
		{
            bool isLeftInteractorRayHovering = leftRayInteractor.TryGetHitInfo(out pos, out norm, out index, out validTarget);
            leftTeleportRay.gameObject.SetActive(EnableLeftTeleport && CheckIfActivated(leftTeleportRay)
                && !isLeftInteractorRayHovering);
		}

		if (rightTeleportRay)
		{
            bool isRightInteractorHovering = rightRayInteractor.TryGetHitInfo(out pos, out norm, out index, out validTarget);
            rightTeleportRay.gameObject.SetActive(EnableRightTeleport && CheckIfActivated(rightTeleportRay)
                && !isRightInteractorHovering);
		}
    }

    public bool CheckIfActivated(XRController controller)
	{
        //teleportActivationButton = InputHelpers.Button.PrimaryButton; // sweeeett!!!! makes use of 'A', 'x' button vs trigger 
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
	}
}
