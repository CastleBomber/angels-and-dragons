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
    public List<GameObject> Matrix;
    private Renderer cubeRenderer;
    private Color newCubeColor;

    [SerializeField]
    public GameObject pixel1, pixel2, pixel3, pixel4;

    // Constructor
    public LightShow()
	{
        Matrix = new List<GameObject>(); // LED Matrix of pixels

        Matrix.Add(pixel1);
        Matrix.Add(pixel2);
        Matrix.Add(pixel3);
        Matrix.Add(pixel4);

        //Debug.Log("LightShow() constructed");
    }

    /**
     * Turns On The Lights one by one
     */
    public void TurnOnTheLights()
    {
        foreach (GameObject obj in Matrix)
        {
            Debug.Log("we in -for loop-");

            cubeRenderer = obj.GetComponent<Renderer>();
            cubeRenderer.material.color = new Color(255, 0, 0);
        }
    }

    /**
     * Turns Off The Lights one by one
     * 
     */
    public IEnumerator TurnOffTheLights()
	{
        yield return new WaitForSeconds(5);

        foreach (GameObject obj in Matrix)
        {
            yield return new WaitForSeconds(1);
            cubeRenderer = obj.GetComponent<Renderer>();
            cubeRenderer.material.color = new Color(0, 0, 0);
        }
    }

	public void DisplayMessageDown()
	{
		Debug.Log("we down");
	}

	void Update()
    {

    }
}
