using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource[] SourcesAudio;
    public float currentVolumen = 0.3f;
    public static SFXManager instance;
    private void Start() {
        instance = this;
        foreach (AudioSource AudioS in instance.SourcesAudio)
        {
            AudioS.playOnAwake = false;
            AudioS.loop = false;
            AudioS.volume = currentVolumen;
        }
    }
    public static void playSound(AudioClip Clip){
        foreach (AudioSource AudioS in instance.SourcesAudio)
        {
            if(!AudioS.isPlaying){
                AudioS.clip = Clip;
                AudioS.Play();
            }
        }
    }
    public static void playSound(AudioClip Clip, float pitch){
        foreach (AudioSource AudioS in instance.SourcesAudio)
        {
            if(!AudioS.isPlaying){
                AudioS.clip = Clip;
                AudioS.pitch = pitch;
                AudioS.Play();
                return;
            }
        }
        
    }

    public static void playSound(AudioClip Clip, float pitch , int chanel){
        AudioSource AudioS = instance.SourcesAudio[chanel];
        AudioS.clip = Clip;
        AudioS.pitch = pitch;
        AudioS.Play();
        return;
    }

     public static void playSound(AudioClip Clip, int chanel){
        AudioSource AudioS = instance.SourcesAudio[chanel];
        AudioS.clip = Clip;
        // AudioS.pitch = pitch;
        AudioS.Play();
        return;
    }

    public static void playSoundOnShot(AudioClip Clip, float pitch , int chanel){
        AudioSource AudioS = instance.SourcesAudio[chanel];
        AudioS.clip = Clip;
        AudioS.pitch = pitch;
        AudioS.PlayOneShot(Clip);
        return;
    }

    public static void setVolumen(float value){
        instance.currentVolumen = value;
        foreach (AudioSource AudioS in instance.SourcesAudio)
        {
            AudioS.volume = value;
        }
    }
}
