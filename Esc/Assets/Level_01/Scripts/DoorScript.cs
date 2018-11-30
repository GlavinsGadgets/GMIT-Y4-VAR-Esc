using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public bool opendoor = false;
    private Animator _animator = null;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
    }
    private void Update()
    {
        if (opendoor)
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        _animator.enabled = true;
        _animator.SetBool("isopen", true);
    }


}
