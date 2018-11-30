using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_System : MonoBehaviour {

    public int maxNumbers = 4;
    public string password = "";
    private string input = "";

    public void keyinputed(string keypressed)
    {
        input += keypressed;

        DoorScript DoorOpen = FindObjectOfType<DoorScript>();
        DoorOpen.OpenDoor();
       
    }

}
