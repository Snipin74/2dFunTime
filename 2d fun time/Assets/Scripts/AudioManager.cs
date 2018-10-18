using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Singleton
    private static AudioManager m_Instance { get; set; }

    //Accessor for audio manager
    public static AudioManager GetInstance()
    {
        return m_Instance;
    }

    //All the sound
    public Sound[] sounds;

    private void Awake()
    {
        //Don't destroy the audio manager when a session ends
        DontDestroyOnLoad(gameObject);

        //Initialize the default values
        if (m_Instance != null && m_Instance != this)
        {
            //Another instance of game manager already exists, destroy this and return
            Destroy(gameObject);
            return;
        }
        else
        {
            m_Instance = this;
        }

        //Add audio source for each sound
        foreach (Sound sound in sounds)
        {
            //Also setup the sounds
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.soundClip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
            sound.source.rolloffMode = AudioRolloffMode.Linear;
            sound.source.maxDistance = 5000;
            sound.source.spatialBlend = 0;
        }
        
    }

    

    public void Play(string name)
    {
        //Find the sound with the specified name
        Sound sound = Array.Find(sounds, x => x.name == name);
        //Play the sound
        if (sound != null)
        {
            sound.source.rolloffMode = AudioRolloffMode.Linear;
            sound.source.spatialBlend = 0;
            AudioSource.PlayClipAtPoint(sound.soundClip, Vector3.zero, sound.volume);
        }
        else
        {
            return;
        }
    }
}