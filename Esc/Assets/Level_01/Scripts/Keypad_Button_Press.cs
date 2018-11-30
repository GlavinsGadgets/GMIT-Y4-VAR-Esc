using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_Button_Press : MonoBehaviour {

    public string keypadCode;
	
	void OnMouseDown()
    {
		if (Input.GetButtonDown("Fire1"))
        {
            Keypad_System KeypadSystem = FindObjectOfType<Keypad_System>();
            KeypadSystem.keyinputed(keypadCode);
        }
    }

}
