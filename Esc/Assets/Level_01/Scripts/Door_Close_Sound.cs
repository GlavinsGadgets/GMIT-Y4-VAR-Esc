using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Close_Sound : MonoBehaviour {

    /*
        Door Closing Sound 
    */

    AudioSource DoorCloseSound;

    void Start()
    {
        DoorCloseSound = gameObject.GetComponent<AudioSource>();
    }
    public void PlayCloseSound()
    {
        DoorCloseSound.Play();
    }
}
