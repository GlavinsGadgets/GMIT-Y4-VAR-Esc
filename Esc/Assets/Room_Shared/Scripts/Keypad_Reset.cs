using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_Reset : MonoBehaviour {

    /*
        Script which calls the reset function on the Keypad_System.cs script.
    */

    // On mouse down the inputed code will be reset
    private void OnMouseDown()
    {
        Keypad_System KeypadSystem = FindObjectOfType<Keypad_System>();

        if (Input.GetButtonDown("Fire1"))
        {
            KeypadSystem.InputReset();
        }
    }

}
