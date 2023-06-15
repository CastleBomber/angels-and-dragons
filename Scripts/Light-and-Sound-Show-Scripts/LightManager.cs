using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class LightManager : MonoBehaviour
{
	protected List<LightShow> stages; // Stages: Reg, Green Blue

	void Start()
	{
		StartCoroutine(demandLights());
	}

	public IEnumerator demandLights()
	{
		yield return new WaitForSeconds(1);

		LightShow lightShowStageRed = new LightShow("PixelStageRed");
		LightShow lightShowStageGreen = new LightShow("PixelStageGreen");
		LightShow lightShowStageBlue = new LightShow("PixelStageBlue");

		// Displays each stage's lights
		lightShowStageRed.TurnOnTheLights(Color.red);
		lightShowStageGreen.TurnOnTheLights(Color.green);
		lightShowStageBlue.TurnOnTheLights(Color.blue);
	}

	public virtual void TurnOnTheLights(Color c)
	{
	}
}