using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WednesdayMusicControl : MonoBehaviour
{
    public AudioSource musicSource;

    public void ToggleMusic()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Pause();
        }
        else
        {
            musicSource.Play();
        }

    }

}
