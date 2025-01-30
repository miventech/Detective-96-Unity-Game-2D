using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWalk : MonoBehaviour
{
    public AudioClip StepSound;
    public void PlaySound(){
        SFXManager.playSound(StepSound , Random.Range(0.6f,1f));
    }
}
