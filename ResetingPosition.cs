using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    Vector3 originalPos;

	// Use this for initialization
	void Start () {
        originalPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("SHIPWALL"))
        {
            transform.localPosition = originalPos;
        }
    }
}
