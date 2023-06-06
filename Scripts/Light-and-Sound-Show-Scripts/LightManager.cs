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
		StartCoroutine(demandLights());
	}

	public IEnumerator demandLights()
	{
		yield return new WaitForSeconds(1);

		// Create child class
		LightShow lightShow = new LightShow();
		

		yield return new WaitForSeconds(1);

		// Call child class function
		lightShow.TurnOnTheLights();

		yield return new WaitForSeconds(1);
	}

	public virtual void TurnOnTheLights()
	{
	}
}