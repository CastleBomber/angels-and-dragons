using UnityEngine;
using UnityEngine.Audio;
using Utilities;
using System;

public class Sound : MonoBehaviour{

	public AudioSource source;  // Point of sound
	public AudioClip clip;

	[Range(0f, 1f)]
	private float volume;
	[Range(.1f, 3f)]
	private float pitch;
}