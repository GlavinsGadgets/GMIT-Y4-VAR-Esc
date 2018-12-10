using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipboard : MonoBehaviour {

    public bool Holding = false;

    Vector3 HoldingPosition = new Vector3(4f, 0.8f, 1f);
    Quaternion HoldingRotation = new Quaternion(0, 180, -70, 1);

    Vector3 RestingPosition = new Vector3(3.752f, 0.512f, 1.696f);
    Quaternion RestingRotation = new Quaternion(0, 25, 0, 0);


    private void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Holding != true)
            {
                gameObject.transform.SetPositionAndRotation(HoldingPosition, HoldingRotation);
                Holding = true;
                Debug.Log(gameObject.transform.rotation);

            }
            else if (Holding == true)
            {
                gameObject.transform.SetPositionAndRotation(RestingPosition, RestingRotation);
                Holding = false;
                Debug.Log(gameObject.transform.rotation);

            }
        }
    }
}
