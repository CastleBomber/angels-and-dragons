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
	public AudioClip[] audioClips;

    public SoundShow()
    {
	}

	public void Start()
	{
		StartCoroutine(PlayAll());
	}

	public IEnumerator PlayAll()
	{
		yield return new WaitForSeconds(0);

		// For each clip, create a Sound obj and attach AudioSource and assign properties
		foreach (AudioClip _clip in audioClips)
		{
			Sound sound = new Sound();
			sound.source = gameObject.AddComponent<AudioSource>();
			sound.source.clip = _clip;
			sound.source.volume = 1;
			sound.source.pitch = 1;


			// Play the all of the Audio clips
			sound.source.Play();

			yield return new WaitForSeconds(_clip.length);
		}
	}
}
