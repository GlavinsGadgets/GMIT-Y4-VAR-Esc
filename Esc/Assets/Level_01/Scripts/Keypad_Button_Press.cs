using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_Button_Press : MonoBehaviour {
    
    // Declares Variables
    public string keyedNum;
    private float ButtonBottomOut;
    private float Vector3X;
    private float Vector3Y;
    private float Vector3Z;

    // On mouse down the button pressed will be sent to the Keypad Manager
    void OnMouseDown()
    {
        // Finds the Keypad Manager System script
        Keypad_System KeypadSystem = FindObjectOfType<Keypad_System>();

        if (Input.GetButtonDown("Fire1"))
        {
            // Binds the number pressed to the KS script
            KeypadSystem.keyinputed(keyedNum);

            // Gets the position of the pressed button and moves it backwards slightly to simulate a user pressing the button
            Vector3 thisobject = transform.position;

            Vector3X = thisobject.x;
            Vector3Y = thisobject.y;
            Vector3Z = thisobject.z;
            ButtonBottomOut = 0.013f;

            // Calls Button Animation
            StartCoroutine(ButtonMovement());
        }
    }
    // Had to use an IEnumerator function to use the WaitForSeconds function
    IEnumerator ButtonMovement()
    {
        // Pushes the button out from current position
        this.transform.position = new Vector3((Vector3X + ButtonBottomOut), Vector3Y, Vector3Z);

        // Waits for .1 of a second
        yield return new WaitForSeconds(0.1f);

        // Pulls the button back from the outer position
        this.transform.position = new Vector3(Vector3X, Vector3Y, Vector3Z);
    }
}
