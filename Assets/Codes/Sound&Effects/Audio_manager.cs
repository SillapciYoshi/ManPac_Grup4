using UnityEngine.Audio;
using UnityEngine;
using JetBrains.Annotations;
using System;

public class Audio_manager : MonoBehaviour
{
    public static Audio_manager instance;

    public Sound[] sounds;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        Play("Background sound");
    }
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "yanl?? yazd?n");
            return;
        }
            
        s.source.Play();
    }
 
}

 