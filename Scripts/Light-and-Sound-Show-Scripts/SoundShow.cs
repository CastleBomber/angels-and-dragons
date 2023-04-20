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

[System.Serializable]
public class SoundShow : SoundManager
{
    public string name;
    public AudioClip clip;

	[Range(0f, 1f)]
    public float volume;

	[Range (.1f, 3f)]
    public float pitch;

    public List<GameObject> speakers;

    [SerializeField]
    public GameObject speaker; 

    [HideInInspector]
    public AudioSource source;

    // Constructor
    public SoundShow()
    {
        speakers = new List<GameObject>();
    }

    void Start()
    {
        SoundShow s = new SoundShow();
        StartCoroutine(TurnOnTheSound());
    }

    /**
     * Turns On The Lights one by one
     */
    public IEnumerator TurnOnTheSound()
    {
        yield return new WaitForSeconds(1);
    }

    /**
     * Turns Off The Sound
     * 
     */
    public IEnumerator TurnOffTheSound()
    {
        yield return new WaitForSeconds(1);
    }

    public void DisplayMessageDown()
    {
        Debug.Log("we down");
    }

    void Update()
    {

    }
}
