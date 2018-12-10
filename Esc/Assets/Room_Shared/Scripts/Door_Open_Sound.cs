using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open_Sound : MonoBehaviour {

    /*
        Door Opening Sound 
    */

    AudioSource DoorOpenSound;
    public bool PlaySound = false;

    void Start()
    {
        DoorOpenSound = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (PlaySound == true)
        {
            PlayOpenSound();
        }
    }

    public void PlayOpenSound()
    {
        StartCoroutine(PlayingOpenSound());
    }
    IEnumerator PlayingOpenSound()
    {
        DoorOpenSound.Play();
        yield return new WaitForSeconds(0.1f);
        PlaySound = false;
    }
}
