using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer_Keyboard : MonoBehaviour {

    /*
        Script that sends the call to the Computer_Monitor.cs script to show the message on the screen.
    */

    // Inits vars
    public bool keyboardPressed = false;

    private void OnMouseDown()
    {
        Computer_Monitor ChangeMaterial = FindObjectOfType<Computer_Monitor>();

        if (Input.GetButtonDown("Fire1"))
        {
            if (keyboardPressed == true)
            {
                ChangeMaterial.Monitor(keyboardPressed);
                keyboardPressed = false;
                // Debug.Log(keyboardPressed);
            }
            else if (keyboardPressed == false)
            {
                ChangeMaterial.Monitor(keyboardPressed);
                keyboardPressed = true;
            }
        }
    }
}
