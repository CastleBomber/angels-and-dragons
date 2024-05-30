using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
	protected List<LightShow> stages; 

	public LightManager()
	{
		stages = new List<LightShow>(); // Stages: StageRed, StageGreen, StageBlue
	}

	void Start()
	{
		StartCoroutine(initializeStages());
		StartCoroutine(stageLightsTurnOn());
		//StartCoroutine(stageLightsTurnOff());
	}

	public IEnumerator initializeStages()
	{
		yield return new WaitForSeconds(0);

		LightShow lightShowStageRed = new LightShow("PixelStageRed");
		LightShow lightShowStageGreen = new LightShow("PixelStageGreen");
		LightShow lightShowStageBlue = new LightShow("PixelStageBlue");

		stages.Add(lightShowStageRed);
		stages.Add(lightShowStageGreen);
		stages.Add(lightShowStageBlue);
	}

	// Displays each stage's lights
	public IEnumerator stageLightsTurnOn()
	{
		yield return new WaitForSeconds(1);

		stages[0].turnOnTheLights(Color.red); 
		stages[1].turnOnTheLights(Color.green);
		stages[2].turnOnTheLights(Color.blue);
	}

	// Turns off each stage's lights
	public IEnumerator stageLightsTurnOff()
	{
		// Turns off the stage lights
		yield return new WaitForSeconds(3);
		stages[0].turnOffTheLights();
		stages[1].turnOffTheLights();
		stages[2].turnOffTheLights();
	}
}