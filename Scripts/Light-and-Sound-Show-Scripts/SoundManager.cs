using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Utilities;
using System;

public class SoundManager : ShowManager
{
	//public List<SoundShow> soundShows;

/*	void Awake()
	{
		foreach(SoundShow s in soundShows)
		{
			s.GetComponent<AudioSource>().loop = false;
			s.source = gameObject.AddComponent<AudioSource>();

			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
	}

	public void Play(string name)
	{
		SoundShow s = Array.Find(soundShows, soundShow => soundShow.name == name);
		s.source.Play();
	}*/

	void DisplayMessageUp()
	{
		Debug.Log("we up");

		//FindObjectOfType<SoundManager>().Play("PlayerDeath");
	}
}