using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    // Inits vars
    public bool opendoor = false;
    private Animator _animator = null;

    // Calls the _animator component and makes sure it is disabled from the begining 
    void Start()
    {
        _animator = GetComponent<Animator>();
       // _animator.enabled = false;
    }
    // Checks to see if the opendoor boolean had been changed
    private void Update()
    {
        // Checks to see if the opendoor is enabled then it will call the OpenDoor function
        if (opendoor)
        {
            OpenDoor();
        }
    }

    // Function to open the door
    public void OpenDoor()
    {
        //_animator.enabled = true;
        _animator.SetBool("isopen", true);
        Debug.Log("Called");
    }

    // Function to close the door
    public void CloseDoor()
    {
        _animator.SetBool("isopen", false);
       // _animator.enabled = false;
    }
}
