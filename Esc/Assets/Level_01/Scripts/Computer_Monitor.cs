using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer_Monitor : MonoBehaviour {

    /*
        Script which waits for the player to click on the keyboard. Monitor function called from Computer_Keyboard.cs.
    */

    // Inits vars
    private MeshRenderer MonitorMesh;
    public Texture ScreenNoMessage;
    public Texture ScreenMessage;

    private void Start()
    {
        MonitorMesh = GetComponent<MeshRenderer>();
    }
    public void Monitor(bool keyboardPressed)
    {
        // Checks if the keyboardPressed bool has been set to true
        if (keyboardPressed)
        {
            MonitorMesh.materials[1].SetTexture("_MainTex", ScreenMessage);
        }
        else if (!keyboardPressed)
        {
            MonitorMesh.materials[1].SetTexture("_MainTex", ScreenNoMessage);
        }
    }
}
