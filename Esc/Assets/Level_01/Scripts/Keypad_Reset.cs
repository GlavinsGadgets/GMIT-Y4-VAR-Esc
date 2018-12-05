using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_Reset : MonoBehaviour {

    // On mouse down the inputed code will be reset
    void OnMouseDown()
    {
        // Finds the Keypad Manager System script
        Keypad_System KeypadSystem = FindObjectOfType<Keypad_System>();

        if (Input.GetButtonDown("Fire1"))
        {
            // Calls the InputReset function if you click on the screen
            KeypadSystem.InputReset();
        }
    }

}
