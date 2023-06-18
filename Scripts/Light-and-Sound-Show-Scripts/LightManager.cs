using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class LightManager : MonoBehaviour
{
	protected List<LightShow> stages; 

	public LightManager()
	{
		stages = new List<LightShow>(); // Stages: Reg, Green Blue
	}

	void Start()
	{
		StartCoroutine(createStages());
		StartCoroutine(stageLightsTurnedOn());
		StartCoroutine(stageLightsTurnedOff());
	}

	public IEnumerator createStages()
	{
		yield return new WaitForSeconds(0);

		LightShow lightShowStageRed = new LightShow("PixelStageRed");
		LightShow lightShowStageGreen = new LightShow("PixelStageGreen");
		LightShow lightShowStageBlue = new LightShow("PixelStageBlue");

		stages.Add(lightShowStageRed);
		stages.Add(lightShowStageGreen);
		stages.Add(lightShowStageBlue);
	}

	public IEnumerator stageLightsTurnedOn()
	{
		yield return new WaitForSeconds(1);

		// Displays each stage's lights
		stages[0].TurnOnTheLights(Color.red); 
		stages[1].TurnOnTheLights(Color.green);
		stages[2].TurnOnTheLights(Color.blue);
	}

	public IEnumerator stageLightsTurnedOff()
	{
		// Turns off the stage lights
		yield return new WaitForSeconds(3);
		stages[0].TurnOffTheLights();
		stages[1].TurnOffTheLights();
		stages[2].TurnOffTheLights();
	}
}