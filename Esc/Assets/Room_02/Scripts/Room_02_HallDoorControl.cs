using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_HallDoorControl : MonoBehaviour {

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
        // Checks to see if the opendoor is enabled then it will call the OpenDoor function
        if (opendoor)
        {
            OpenDoor();
        }
        Room_02_Move_Player Move = FindObjectOfType<Room_02_Move_Player>();
        if (Move.PlayerReachedInsideRoom == true)
        {
            opendoor = false;
            CloseDoor();
        }
    }

    public void OpenDoor()
    {
        Door_Open_Sound OpenCall = FindObjectOfType<Door_Open_Sound>();
        _animator.SetBool("isopen", true);
        OpenCall.PlaySound = true;
    }
    public void CloseDoor()
    {
        //Door_Close_Sound CloseCall = FindObjectOfType<Door_Close_Sound>();
        _animator.SetBool("isopen", false);
        //CloseCall.PlaySound = true;
    }
}
