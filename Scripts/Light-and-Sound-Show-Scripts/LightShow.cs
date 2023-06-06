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

public class LightShow : LightManager
{
    protected List<GameObject> Matrix;
    public GameObject pixel1, pixel2;

    // Constructor
    public LightShow()
	{
        Matrix = new List<GameObject>(); // LED Matrix of pixels
		Matrix.Add(pixel1);
		Matrix.Add(pixel2);
	}

    /**
     * Turns On The Lights one by one
     */
    public override void TurnOnTheLights()
    {
        List<MeshRenderer> renderers = new List<MeshRenderer>();
        MeshRenderer renderer = null;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Pixel"))
        {
            renderer = obj.GetComponent<MeshRenderer>();
            renderer.material.color = new Color(255, 0, 0);
		}
    }

    /**
     * Turns Off The Lights one by one
     * 
     */
/*    public IEnumerator TurnOffTheLights()
	{
        yield return new WaitForSeconds(5);

        foreach (GameObject obj in Matrix)
        {
            yield return new WaitForSeconds(1);
            cubeRenderer = obj.GetComponent<MeshRenderer>();
            cubeRenderer.material.color = new Color(0, 0, 0);
        }
    }*/

}
