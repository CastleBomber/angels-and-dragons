using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class LightManager : ShowManager
{
	void Start()
	{
		StartCoroutine(goods());
	}

	public IEnumerator goods()
	{
		yield return new WaitForSeconds(1);

		LightShow lightShow = new LightShow();
		lightShow.TurnOnTheLights();

	}


	/*	protected virtual void TurnOnTheLights()
		{

		}*/
}