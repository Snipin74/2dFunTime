using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    //The actual audio clip
    public AudioClip soundClip;

    //Sound file's properties
    [Range(0.0f, 1.0f)]
    public float volume;

    [Range(0.1f, 3.0f)]
    public float pitch;

    public string name;
    public bool loop;

    [HideInInspector]
    public AudioSource source;

}