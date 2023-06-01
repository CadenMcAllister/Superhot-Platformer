using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject soundEffect;
    public TimeSlow timeSlow;
    public AudioClip soundEffectClip;
    private bool isPlaying = false;

    void Start()
    {
        bool isActivated = timeSlow.isActivated;
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // Set the audio to loop
        audioSource.playOnAwake = false; // Don't play the audio on awake
        audioSource.spatialBlend = 0f; // Set the audio to 2D
        audioSource.rolloffMode = AudioRolloffMode.Linear; // Set the rolloff mode to linear
        audioSource.maxDistance = 100f; // Set the max distance to 100 units
        audioSource.volume = 1f; // Set the volume to normal
        audioSource.Play();
    }

    void Update()
{
if (timeSlow.isActivated)
{
    audioSource.volume = 0.3f;
    if (!isPlaying && !audioSource.isPlaying)
    {
        audioSource.PlayOneShot(soundEffectClip, 0.5f);
        isPlaying = true;
    }
}

    else
    {
        audioSource.volume = 1f; // Reset the volume to normal
        isPlaying = false; // Reset the flag when the sound effect is no longer playing
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}

}
