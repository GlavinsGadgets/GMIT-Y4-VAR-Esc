using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_Keypad_Reset : MonoBehaviour {

    /*
        Script which calls the reset function on the Keypad_System.cs script.
    */

    // On mouse down the inputed code will be reset
    private void OnMouseDown()
    {
        Room_02_Keypad_System KeypadSystem = FindObjectOfType<Room_02_Keypad_System>();

        if (Input.GetButtonDown("Fire1"))
        {
            KeypadSystem.InputReset();
        }
    }

}
