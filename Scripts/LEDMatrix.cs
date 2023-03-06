/*
 * Author: CastleBomber
 * Date: February 17th, 2023
 * 
 * 
 * Acknowledgements:
 * How to Change Color of 3D object - Alexander Zotov, youtube tutorial
 * 
 * 
 * Tips: code folding: ctrl+m+m
 * full screen: alt+shift+enter
 * 
*/

using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class LEDMatrix : MonoBehaviour
{
    [SerializeField]
    public GameObject pixel1, pixel2, pixel3, pixel4;
    public List<GameObject> Pixels = new List<GameObject>();
    private Renderer cubeRenderer;
    private Color newCubeColor;

    void Start()
    {
        // Pixel 1
        cubeRenderer = pixel1.GetComponent<Renderer>();
        newCubeColor = new Color(255,0,0);
        cubeRenderer.material.color = newCubeColor;

        // Pixel 2
        cubeRenderer = pixel2.GetComponent<Renderer>();
        cubeRenderer.material.color = new Color(0,255,0);

        // Pixel 3
        cubeRenderer = pixel3.GetComponent<Renderer>();
        cubeRenderer.material.color = new Color(0, 0, 255);

        // Pixel 4
        cubeRenderer = pixel4.GetComponent<Renderer>();
        cubeRenderer.material.color = new Color(255, 255, 255);

        Pixels.Add(pixel1);
        Pixels.Add(pixel2);
        Pixels.Add(pixel3);
        Pixels.Add(pixel4);

        foreach (GameObject obj in Pixels)
		{
            cubeRenderer = obj.GetComponent<Renderer>();
            cubeRenderer.material.color = new Color(255, 0, 0);
		}
    }

    void TurnOnTheLights()
	{
        /*int[,] matrix = new int[2,2];
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        // Turn on all the cubes
		for (int i = 0; i < row * col; i++)
		{
            matrix[i / col, i & col] = i + 1;
            //turn material on
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
		}*/
    }

    void Update()
    {

    }
}
