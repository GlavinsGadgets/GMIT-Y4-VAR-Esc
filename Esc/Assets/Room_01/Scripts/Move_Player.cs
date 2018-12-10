using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Player : MonoBehaviour {

    /*
        Script which moves the player after opening the door. 
    */

    // Inits vars
    public bool DoorOpened;
    public bool PlayerReachedPoint = false;
    private Vector3 OutsideRoom = new Vector3(2.6f, 1.1f, 0f);
    private float step;
    public float stepspeed;

    public bool Reset; // Bool which resets players position (Used for play testing!).

    private void Update()
    {
        step = stepspeed * Time.deltaTime;

        // Checks if the door is open and calls the MovePlayer funciton.
        if (DoorOpened)
        {
            MovePlayer();
        }
        
        // Checks if the player has reached the point outside the room.
        if (gameObject.transform.position == OutsideRoom)
        {
            StartCoroutine(LoadWait());
        }
        else if (gameObject.transform.position != OutsideRoom)
        {
            PlayerReachedPoint = false;
        }
        
        // Checks to see if the Reset bool has been set to true.
        if (Reset)
        {
            ResetPlayer();
        }
    }

    public void MovePlayer()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, OutsideRoom, step);
    }
    public void ResetPlayer() {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 1.1f, 0), (10 * Time.deltaTime));
    }

    IEnumerator LoadWait()
    {
        yield return new WaitForSeconds(1f);
        PlayerReachedPoint = true;
        SceneManager.LoadScene(2);
    }

}
