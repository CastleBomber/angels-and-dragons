using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Plays audio with volume when player is detected inside sphere collider
public class ZoneAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public SphereCollider sphereCollider; // Audio zone
    public Transform player;
    private bool isMenuOverriding = false; // Flag to check if menu is overriding

    void Start()
    {
        // Game starts off with music playing, not audible until inside zone
        audioSource.volume = 0.0f;
        audioSource.Play();
        audioSource.loop = true;
    }

    void Update()
    {
        // If the menu is overriding, skip this script's volume control
        if (isMenuOverriding) 
        {
            return; 
        } 

        // Center of the sphere collider
        Vector3 sphereCenter = sphereCollider.transform.position + sphereCollider.center;

        // Calculate the distance between the object and the center of the sphere
        float distance = Vector3.Distance(player.position, sphereCenter);

        // Check if distance is less than radius of the sphere collider (localScale.x accounts for scaling)
        if (distance < sphereCollider.radius * sphereCollider.transform.localScale.x)
        {
            Debug.Log("Player inside of sphere");
            audioSource.volume = 1.0f;
		} 
        else
        {
            // Debug.Log("Player outside of sphere");
            audioSource.volume = 0.0f;
        }
    }

    public void OverrideVolume(bool overrideControl)
    {
        isMenuOverriding = overrideControl;

        if(overrideControl){
            audioSource.volume = 0.0f;
        }
    }
}
