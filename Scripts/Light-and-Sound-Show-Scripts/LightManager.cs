
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class LightManager : MonoBehaviour
{
	void Start()
	{
		LightShow lightShow = new LightShow();
		//lightShow.TurnOnTheLights();
		//StartCoroutine(lightShow.TurnOnTheLights());
		//StartCoroutine(lightShow.TurnOffTheLights());
	}

	void DisplayMessageUp()
	{
		Debug.Log("we up");
	}
}