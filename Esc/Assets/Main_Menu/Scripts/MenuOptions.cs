﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {

    /*
        Main menu screen options. 
    */

    // Select which button the script had been choosen to be placed on
    public bool PlayButton;
    public bool QuitButton;
    public bool MainMenu;

    // OnMouseDown checks if the fire button has been pressed
    void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1") && PlayButton)
        {
            PlayGame();
        }
        if (Input.GetButtonDown("Fire1") && QuitButton)
        {
            QuitGame();
        }
        if (Input.GetButtonDown("Fire1") && MainMenu)
        {
            BackToMainMenu();
        }

    }
    void PlayGame()
    {
        if (PlayButton)
        {
            SceneManager.LoadScene(1);
            // Debug.Log("Play Level 1");
        }
    }
    void QuitGame()
    {
        if (QuitButton)
        {
            Application.Quit();
            // Debug.Log("Quit App");
        }
    }

    void BackToMainMenu()
    {
        if (MainMenu)
        {
            SceneManager.LoadScene(0);
        }
    }

}
