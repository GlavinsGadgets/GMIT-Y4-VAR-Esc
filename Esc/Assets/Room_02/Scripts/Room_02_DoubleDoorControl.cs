using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_DoubleDoorControl : MonoBehaviour {

    /*
        Door to open the door if the opendoor bool has been set to true.
    */

    // Inits vars
    private Animator _animator = null;
    public bool opendoor = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Room_02_Move_Player MovePlayer = FindObjectOfType<Room_02_Move_Player>();
        // Checks to see if the opendoor is enabled then it will call the OpenDoor function
        if (opendoor)
        {
            OpenDoor();
            MovePlayer.PlayerWon = true;
        }

    }

    public void OpenDoor()
    {
        Door_Open_Sound OpenCall = FindObjectOfType<Door_Open_Sound>();
        OpenCall.PlayOpenSound();
        _animator.SetBool("DoorOpen", true);
    }
    public void CloseDoor()
    {
        Door_Close_Sound CloseCall = FindObjectOfType<Door_Close_Sound>();
        CloseCall.PlayCloseSound();
        _animator.SetBool("DoorOpen", false);
    }
}
