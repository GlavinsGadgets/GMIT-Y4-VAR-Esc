using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_02_Move_Player : MonoBehaviour {

    public bool startMovement = false;
    public bool PlayerReachedInsideRoom = false;
    private Vector3 InsideRoom = new Vector3(4f, 1.1f, 0f);
    private float step;
    public float stepspeed;

    public bool Reset;

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
            PlayerReachedInsideRoom = true;
        }
        else if (gameObject.transform.position != InsideRoom)
        {
            PlayerReachedInsideRoom = false;
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
    }

}
