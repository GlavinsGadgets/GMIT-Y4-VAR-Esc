using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open_Sound : MonoBehaviour {

    /*
        Door Opening Sound 
    */

    AudioSource DoorOpenSound;

    void Start()
    {
        DoorOpenSound = gameObject.GetComponent<AudioSource>();
    }
    public void PlayOpenSound()
    {
        DoorOpenSound.Play();
    }
}
