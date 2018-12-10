using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Close_Sound : MonoBehaviour {

    /*
        Door Closing Sound 
    */

    AudioSource DoorCloseSound;
    public bool PlaySound = false;

    void Start()
    {
        DoorCloseSound = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (PlaySound == true)
        {
            PlayCloseSound();
        }
    }

    public void PlayCloseSound()
    {
        StartCoroutine(PlayingClosingSound());
    }
    IEnumerator PlayingClosingSound()
    {
        DoorCloseSound.Play();
        yield return new WaitForSeconds(0.1f);
        PlaySound = false;
    }
}
