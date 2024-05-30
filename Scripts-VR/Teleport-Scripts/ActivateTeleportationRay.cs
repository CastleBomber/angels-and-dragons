using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

// XR Controller(Action-based) NEW
public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate; // Primary/primaryButton
    public InputActionProperty rightActivate;
    public InputActionProperty leftCancel; // Select/gripPressed
    public InputActionProperty rightCancel;

    public XRRayInteractor leftRay; // Ray menu pointer
    public XRRayInteractor rightRay;

    void Update()
    {
        // Ray hovering over a menu (avoid teleport); returns True if we hit something
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
		bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);

        // Teleport! All conditions met: !menu hovering, !grip pressed, and primary pressed
		leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(!isRightRayHovering && rightCancel.action.ReadValue<float>() == 0 &&  rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
