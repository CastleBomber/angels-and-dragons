using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * VR Player Rig has ContinuousMovement Script
 * 
 * Left hand joystick controls movement
 * Right hand joystick controls snapping to a new direction
 * 
 */                                                                                                                                                                                                                                                                                                                                                                                            
public class ContinuousMovement : MonoBehaviour
{
	//private XRRig rig;                      // Provides access to the game's head object
    private XROrigin rig;
	private CharacterController character;
	public XRNode inputSource;
	private Vector2 inputAxis;
	public float speed = 1;
	public float fallingSpeed;
	public float gravity = -1f;             //-9.81f;
    public float additionalHeight = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        character = GetComponent<CharacterController>();
        //rig = GetComponent<XRRig>();
        rig = GetComponent<XROrigin>();
    }

    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

	private void FixedUpdate()
	{
        /*CapsuleFollowHeadset();

        // Movement will always face the direction we are looking at
        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);
        character.Move(direction * Time.fixedDeltaTime * speed);

        // Gravity
        bool isGrounded = CheckIfGrounded();

		if (isGrounded)
		{
            fallingSpeed = 0;
		}
        else
        {
            //fallingSpeed += gravity * Time.fixedDeltaTime;
        }

        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);*/
    }

    // Head Movement
    void CapsuleFollowHeadset()
	{
        /*character.height = rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height/2 + character.skinWidth, capsuleCenter.z);*/
	}

	// Tells us if on ground
	bool CheckIfGrounded()
	{
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);

        return hasHit;
	}
}
