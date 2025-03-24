using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NoiseTrigger : MonoBehaviour
{
    
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
