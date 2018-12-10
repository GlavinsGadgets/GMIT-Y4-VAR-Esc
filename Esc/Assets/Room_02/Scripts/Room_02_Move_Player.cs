using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_Move_Player : MonoBehaviour {

    public bool startMovement = false;
    public bool PlayerWon = false;
    public bool PlayerReachedInsideRoom = false;
    public bool PlayerReachedFinalPosition = false;
    public bool Reset;
    public float stepspeed;
    private float step;

    private Vector3 InsideRoom = new Vector3(4f, 1.1f, 0f);
    private Vector3 CenterRoom = new Vector3(4f, 1.1f, 0.5f);
    private Vector3 FinalPosition = new Vector3(7f, 1.1f, 0.5f);

    private void Start()
    {
        Room_02_HallDoorControl OnLoadDoor = FindObjectOfType<Room_02_HallDoorControl>();
        startMovement = true;
        OnLoadDoor.opendoor = true;
    }
    // Update is called once per frame
    private void Update ()
    {
        step = stepspeed * Time.deltaTime;
        

        if (startMovement)
        { 
            OnLoadMove();
        }
        if (PlayerWon == true)
        {
            OnFinalScreen();
        }

        if (gameObject.transform.position == InsideRoom)
        {
            Room_02_HallDoorControl OnLoadDoor = FindObjectOfType<Room_02_HallDoorControl>();
            PlayerReachedInsideRoom = true;
            OnLoadDoor.opendoor = false;
            startMovement = false;
        }
        if (gameObject.transform.position == FinalPosition)
        {
            Room_02_DoubleDoorControl CloseDoor = FindObjectOfType<Room_02_DoubleDoorControl>();
            CloseDoor.CloseDoor();
        }
        if (PlayerReachedInsideRoom == true)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, CenterRoom, step);
        }
        
        if (Reset)
        {
            OnLevelReset();
        }
    }

    public void OnLoadMove()
    {
        StartCoroutine(LoadWait());
    }
    public void OnLevelReset()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 1.1f, 0), (10 * Time.deltaTime));
        PlayerReachedInsideRoom = false;
        Start();
    }

    IEnumerator LoadWait()
    {
        yield return new WaitForSeconds(1f);
        gameObject.transform.position = Vector3.MoveTowards(transform.position, InsideRoom, step);
    }

    public void OnFinalScreen()
    {
        PlayerReachedInsideRoom = false;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, FinalPosition, step);
        PlayerReachedFinalPosition = true;
    }
}
