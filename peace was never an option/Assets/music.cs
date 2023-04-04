using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class music : MonoBehaviour
{
    void Awake()
    {
        // Find all audio source objects in the scene
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Check if there is already an audio source object
        if(audioSources.Length > 1)
        {
            // Destroy this audio source object if another one already exists
            Destroy(gameObject);
        }
        else
        {
            // Make this audio source object persistent between scenes
            DontDestroyOnLoad(gameObject);
        }
    }



}
