using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlayMusicOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public AudioSource menuAudioSource;
    public List<ZoneAudio> zoneAudios;

    // Plays audio from specific zone on the map, muting out the area's audio as well
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Mute all zone audios that may conflict
        foreach (ZoneAudio zoneAudio in zoneAudios)
        {
			zoneAudio.OverrideVolume(true);
		}

		menuAudioSource.volume = 1.0f;
	}

    public void OnPointerExit(PointerEventData eventData) 
    {
        menuAudioSource.volume = 0.0f;

		// Unmute all zone audios after the menu audio stops
		foreach (ZoneAudio zoneAudio in zoneAudios)
        {
			zoneAudio.OverrideVolume(false); // Allow zone audio to resume control
		}
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        menuAudioSource.volume = 0.0f;

		foreach (ZoneAudio zoneAudio in zoneAudios)
        {
            zoneAudio.OverrideVolume(false);
        }
    }
}
