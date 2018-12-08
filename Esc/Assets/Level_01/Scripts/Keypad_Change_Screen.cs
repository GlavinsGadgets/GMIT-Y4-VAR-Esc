using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad_Change_Screen : MonoBehaviour {

    /*
        Script which changes the text on the screen.
    */

    // Inits vars
    private TextMeshPro textmesh;
    private int maxNumbers;
    private string input = "";

    // Gets game components
    private void Start()
    {
        textmesh = GetComponent<TextMeshPro>();
        Keypad_System KeySys = FindObjectOfType<Keypad_System>();
        maxNumbers = KeySys.password.Length;
    }

    // Updates the outputed text when the Keypad_System script calls it
    public void ChangeText(string NewText)
    {
        input += NewText;
        textmesh.text = input;
    }

    // Resets the text to default
    public void ResetText()
    {
        input = "";
        textmesh.text = "____";
    }

    // Changes output on the screen when an Input Error is encounted
    public void InputError()
    {
        input = "";
        // Calls the WaitInputError function and sends text within the function
        StartCoroutine(WaitInputError("Err"));
    }
    IEnumerator WaitInputError(string text)
        // IEnumerator used for the WaitForSeconds function
    {
        // Sets the text on the screen to the text inputed from the function call
        textmesh.text = text;
        // Text waits for 1 second
        yield return new WaitForSeconds(1.2f);
        // Calls the Reset function
        ResetText();
    }

}
