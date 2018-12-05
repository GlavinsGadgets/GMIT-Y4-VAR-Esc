using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kepad_screen : MonoBehaviour {

    // On mouse down the inputed code will be reset
    void OnMouseDown()
    {
        // Finds the Keypad Manager System script
        Keypad_System KeypadSystem = FindObjectOfType<Keypad_System>();

        if (Input.GetButtonDown("Fire1"))
        {
            KeypadSystem.InputReset();
        }
    }
}
