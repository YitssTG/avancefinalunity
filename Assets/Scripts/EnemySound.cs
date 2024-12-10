using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : MonoBehaviour
{
    public float detectionRadius = 5f; 
    private AudioSource audioSource;
    public Transform player; 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (player != null)
        {
            float distance = Mathf.Sqrt(
            Mathf.Pow(player.position.x - transform.position.x, 2) +
            Mathf.Pow(player.position.y - transform.position.y, 2)
        );

            if (distance <= detectionRadius)
            {
                PlaySound();
            }
            else
            {
                StopSound();
            }
        }
    }
    void PlaySound()
    {
        if (!audioSource.isPlaying) 
        {
            audioSource.Play();
        }
    }

    void StopSound()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}

