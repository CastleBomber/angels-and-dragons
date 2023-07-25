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
using Utilities;
using System;
using UnityEngine.Video;

public class LightShow : MonoBehaviour
{
    protected List<GameObject> matrix;  // Built from pixels
    protected string pixelStageTag;     // given to each pixel to determine stage
    public VideoClip vc;

	// Constructor
	public LightShow(string pixelTag)
	{
        matrix = new List<GameObject>(); // LED Matrix of pixels
        pixelStageTag = pixelTag;        // Identifies proper pixels

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(pixelStageTag))
        {
            matrix.Add(obj);
        }
	}

    /**
     * Turns On The Lights one by one
     */
    public void turnOnTheLights(Color c)
    {
        MeshRenderer renderer = null;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(pixelStageTag))
        {
            renderer = obj.GetComponent<MeshRenderer>();
            renderer.material.color = new Color(255, 0, 0);
            renderer.material.color = c;
		}
    }

    /**
     * Turns Off The Lights one by one
     * 
     */
    public void turnOffTheLights()
    {
        MeshRenderer renderer = null;

        foreach (GameObject obj in matrix)
        {
			renderer = obj.GetComponent<MeshRenderer>();
			renderer.material.color = new Color(0, 0, 0);
        }
    }

}
