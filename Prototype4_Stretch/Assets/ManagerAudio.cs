using System.Collections;
using System.Collections.Generic;
using Dimension19.AudioEvents;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    public AudioEventsComponent audioEventsComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        SetPitch(audioEventsComponent.audioSource.pitch);
        SetVolume(audioEventsComponent.audioSource.volume);
        SetTime(audioEventsComponent.audioSource.time);
        SetDoppler(audioEventsComponent.audioSource.dopplerLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPitch(float sliderValue)
    {
        audioEventsComponent.audioSource.pitch = sliderValue;
    }

    public void SetVolume(float sliderValue)
    {
        audioEventsComponent.audioSource.volume = sliderValue;
    }

    public void SetTime(float sliderValue)
    {
        audioEventsComponent.audioSource.time = sliderValue;
    }

    public void SetDoppler(float sliderValue)
    {
        audioEventsComponent.audioSource.dopplerLevel = sliderValue;
    }
}
