using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_Move_Player : MonoBehaviour {

    public bool startMovement = false;
    public bool PlayerReachedInsideRoom = false;
    public bool Reset;
    public float stepspeed;
    private float step;

    private Vector3 InsideRoom = new Vector3(4f, 1.1f, 0f);
    private Vector3 CenterRoom = new Vector3(4f, 1.1f, 0.5f);

    private void Start()
    {
        Room_02_HallDoorControl OnLoadDoor = FindObjectOfType<Room_02_HallDoorControl>();
        startMovement = true;
        OnLoadDoor.opendoor = true;
    }
    // Update is called once per frame
    void Update ()
    {
        step = stepspeed * Time.deltaTime;

        if (startMovement)
        { 
            OnLoadMove();
        }
        if (gameObject.transform.position == InsideRoom)
        {
            Room_02_HallDoorControl OnLoadDoor = FindObjectOfType < Room_02_HallDoorControl > ();

            PlayerReachedInsideRoom = true;
            startMovement = false;
            OnLoadDoor.opendoor = false;
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
        gameObject.transform.position = Vector3.MoveTowards(transform.position, InsideRoom, step);
       
    }
    public void OnLevelReset()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 1.1f, 0), (10 * Time.deltaTime));
        PlayerReachedInsideRoom = false;
        Start();
    }

}
