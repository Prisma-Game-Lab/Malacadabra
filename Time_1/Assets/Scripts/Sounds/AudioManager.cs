using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.Audio;
using Debug = UnityEngine.Debug;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.GetInt("FirstGame") == 0)
        {
            PlayerPrefs.SetFloat("MasterSoundPrefs", 100f);
            PlayerPrefs.SetInt("FirstGame", 1);
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = PlayerPrefs.GetFloat("MasterSoundPrefs") * 0.01f;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        UpdateSoundVolumes();
    }

    private void Start()
    {
        
    }
    public void Play(string name)
    {
        
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Play();
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Stop();
            return;
        }
        s.source.Stop();
    }
    public void StopAllSounds()
    {
        foreach (Sound sound in sounds)
        {
            sound.source.Stop();
        }
    }
    public void UpdateSoundVolumes()
    {
        foreach (Sound s in sounds)
            s.source.volume = PlayerPrefs.GetFloat("MasterSoundPrefs");
    }
}