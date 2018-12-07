using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlash : MonoBehaviour {

    Light pointLight;
    public float minWaitTime = 0.1f;
    public float maxWaitTime = 1f;

    void Start () {
        pointLight = GetComponent<Light>();
        StartCoroutine(Flashing());
	}

    IEnumerator Flashing()
    {
        while (true)
        {
            // Randomly flashes the light on and off depending on the min and max wait times.
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            pointLight.enabled = ! pointLight.enabled;
        }
    }

}
