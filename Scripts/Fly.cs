using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Fly : MonoBehaviour
{
	private XRRig rig;
	private CharacterController character;
	public XRController leftController;
	public XRController rightController;
	public InputHelpers.Button flyUpButtonLeft;
	public InputHelpers.Button flyUpButtonRight;
	public InputHelpers.Button flyDownButtonLeft;
	public InputHelpers.Button flyDownButtonRight;
	public float flyingSpeed;
	public float activationThreshold;

	// called before the first frame update
	void Start()
	{
		character = GetComponent<CharacterController>();
		rig = GetComponent<XRRig>();
	}

	// called once per frame
	void Update()
	{
		/*InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(inputSourceLeft);
		deviceLeft.TryGetFeatureValue(CommonUsages.trigger, out triggerValueLeft);

		InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(inputSourceRight);
		deviceRight.TryGetFeatureValue(CommonUsages.trigger, out triggerValueRight);*/


	}

	private void FixedUpdate()
	{
		buttonFlightListener();
	}

	void buttonFlightListener()
	{
		if (CheckIfActivated(leftController, flyUpButtonLeft) && CheckIfActivated(rightController, flyUpButtonRight))
		{
			character.Move(Vector3.up);
		}

		if (CheckIfActivated(leftController, flyDownButtonLeft) && CheckIfActivated(leftController, flyDownButtonRight))
		{
			character.Move(Vector3.down);
		}
	}

	public bool CheckIfActivated(XRController controller, InputHelpers.Button button)
	{
		InputHelpers.IsPressed(controller.inputDevice, button, out bool isActivated, activationThreshold);
		return isActivated;
	}
}
