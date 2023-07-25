/*
 * Author: CastleBomber
 * Date: February 17th, 2023
 * 
 * 
 * Tips: 
 *  code folding: ctrl+m+m
 *  full screen: alt+shift+enter
 *  solution explorer: ctrl+alt+L
 * 
*/

using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Utilities;
using System;

public class SoundShow : MonoBehaviour
{
	public Sound[] sounds;
	public AudioClip clipPublic;
	public AudioClip[] audioClips;

    // Constructor
    public SoundShow()
    {
	}

	public void Awake()
	{
		/*foreach (Sound sound in sounds)
		{
			// Creating AudioSources for each sound
			sound.source = gameObject.AddComponent<AudioSource>();

			// Set properties
			sound.source.clip = sound.clip;
			sound.source.volume = sound.volume;
			sound.source.pitch = sound.pitch;
			sound.source.loop = sound.loop;
		}*/

		
	}

	public void Start()
	{
		StartCoroutine(PlayAll());
	}

	public IEnumerator PlayAll()
	{
		yield return new WaitForSeconds(0);

		foreach (AudioClip _clip in audioClips)
		{

			Sound sound = new Sound();
			sound.source = gameObject.AddComponent<AudioSource>();
			sound.source.clip = _clip;
			sound.source.volume = 1;
			sound.source.pitch = 1;

			sound.source.Play();

			yield return new WaitForSeconds(_clip.length);
		}
	}

	public void TurnOnTheSound(string name)
	{    
		try
		{
			//Sound s = Array.Find(sounds, sound => sound.name == name);
			//s.source.Play();

			//Sound s = GameObject.Find(name);

			AudioSource AS = GameObject.FindGameObjectWithTag("SoundShow").GetComponent<AudioSource>();
			AS.Play();

		} catch
		{
			Debug.Log("Yo");
			Debug.Log("Sound " + name + " not found!");
		} 
    }

	public void TurnOffTheSound()
	{
	}
}
