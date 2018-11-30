using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public bool opendoor = false;

    private Animator _animator = null;

    void Start()
    {
        _animator = GetComponent<Animator>();

        
    }
    private void Update()
    {
        if (opendoor)
        {
            OnTriggerEnter();
        }
    }

    private void OnTriggerEnter()
    {
        _animator.SetBool("isopen", true);
    }


}
