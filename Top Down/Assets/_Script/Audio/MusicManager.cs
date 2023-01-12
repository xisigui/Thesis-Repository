using UnityEngine.Audio;
using System;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public Music[] musics;
    public static MusicManager instance;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }            

        DontDestroyOnLoad(gameObject);

        foreach (Music s in musics)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.audioMixer;
        }
    }

    void Start()
    {
        Play("Main Music");        
    }
    
    public void Play(string name)
    {
        Music m = Array.Find(musics, sound => sound.name == name);
        m.source.Play();
    }

    public void StopPlaying (string name)
    {
        Music m = Array.Find(musics, sound => sound.name == name);
        if (m == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        m.source.Stop();
    }

    public void Pause(string name)
    {
        Music m = Array.Find(musics, sound => sound.name == name);
        m.source.Pause();
    }
}
