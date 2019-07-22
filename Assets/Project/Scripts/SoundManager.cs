using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField]
    private AudioSource soundFX;
    [SerializeField]
    private AudioClip buttonClick, shootClip;
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void OnButtonClick()
    {
        //clip sellection
        soundFX.clip = buttonClick;
        soundFX.Play();

    }
    public void ShootingSound()
    {
        soundFX.clip = shootClip;
        soundFX.Play();
    }
}
