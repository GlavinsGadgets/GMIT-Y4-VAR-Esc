using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Change_Keypad_Text : MonoBehaviour {

    // Initalizes vars
    private TextMeshPro textmesh;
    private int maxNumbers;
    private string input = "";

    // Gets game components
    void Start()
    {
        textmesh = GetComponent<TextMeshPro> ();
        Keypad_System KeySys = FindObjectOfType<Keypad_System>();
        maxNumbers = KeySys.maxNumbers;
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
        // Calls the WaitInputError function and sends text within the function
        StartCoroutine(WaitInputError("Err"));
    }
    // IEnumerator used for the WaitForSeconds function
    IEnumerator WaitInputError(string text)
    {
        // Sets the text on the screen to the text inputed from the function call
        textmesh.text = text;
        // Text waits for 1 second
        yield return new WaitForSeconds(1f);
        // Calls the Reset function
        ResetText();
    }

}
