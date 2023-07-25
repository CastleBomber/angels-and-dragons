using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Utilities;
using System;

public class SoundManager : MonoBehaviour
{
	protected List<SoundShow> stages;

	public SoundManager()
	{
		stages = new List<SoundShow>();
	}

	void Awake()
	{
		StartCoroutine(initializeStages());
	}

	void Start()
	{
		StartCoroutine(stageSoundsTurnOn());

		SoundShow[] stagesFromGetComponents = GetComponents<SoundShow>();
	}
	
	public IEnumerator initializeStages()
	{
		yield return new WaitForSeconds(0);

		SoundShow soundShowStageRed = new SoundShow();

		stages.Add(soundShowStageRed); // Note: try new method
 	}

	public IEnumerator stageSoundsTurnOn()
	{
		yield return new WaitForSeconds(1);

		//stages[0].TurnOnTheSound("Death-Note");
	}
}