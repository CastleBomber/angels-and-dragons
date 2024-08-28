using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Warp to designated area (need a dynamic way to reference area)
public class WarpToArea : MonoBehaviour
{
    public Transform warpTarget; // Transform reference to warp target (new)
    private Transform Player;
    public GameObject menu;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Player = player.transform;
    }

	// Button clicked , take input on menu and warp to that location
	public void Warp()
    {
        // Warp Player to target
        Player.position = warpTarget.position;

        // Turns controller back on after button turned it off prevent interference with position
        Player.GetComponent<CharacterController>().enabled = true;

        CloseMenu();
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
    }
}
