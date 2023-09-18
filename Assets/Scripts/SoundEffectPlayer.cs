using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip music, coin, deathEnemy, deathVoid, win;

    public void AudioMusic()
    {
        src.clip = music;
        src.Play();
    }

    public void AudioCoin()
    {
        src.clip = coin;
        src.Play();
    }

    public void AudioDeathEnemy()
    {
        src.clip = deathEnemy;
        src.Play();
    }

    public void AudioDeathVoid()
    {
        src.clip = deathVoid;
        src.Play();
    }
    public void AudioWin()
    {
        src.clip = win;
        src.Play();
    }
}
