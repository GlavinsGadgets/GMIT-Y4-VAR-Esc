using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_System : MonoBehaviour {

    // Declares Variables
    public int maxNumbers = 4;
    public string password = "";
    public string input = "";

    // Waits for input from Keypad_Button_Press Script
    public void keyinputed(string keyedNum)
    {
        // Adds keyedNum onto input string
        input += keyedNum;

        // Finds other script objects
        Change_Keypad_Text ChangeText = FindObjectOfType<Change_Keypad_Text>();
        DoorScript DoorOpen = FindObjectOfType<DoorScript>();

        // Checks if the length of the number inputed is less than maxNumbers
        if (input.Length <= maxNumbers)
        {
            // Sends text to the TextMeshPro text
            ChangeText.ChangeText(keyedNum);

            // Checks if the inputed string is equal to the password
            if (input == password)
            {
                DoorOpen.OpenDoor();
            }
        }
        // Checks if the inputed value is longer than maxNumbers calls InputError function if it is and resets input
        else if (input.Length > maxNumbers)
        {
            input = "";
            ChangeText.InputError();
        }

    }
    // Called when the user presses on the screen part of the keypad
    public void InputReset()
    {
        // Finds script to change the textmeshpro object
        Change_Keypad_Text ChangeText = FindObjectOfType<Change_Keypad_Text>();
        DoorScript DoorOpen = FindObjectOfType<DoorScript>();

        //Resets the input to default parameters
        input = "";
        ChangeText.ResetText();
        DoorOpen.CloseDoor();

    }

}
