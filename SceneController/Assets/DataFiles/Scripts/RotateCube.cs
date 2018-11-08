using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

	// Use this for initialization
	void Start () { 
        Debug.Log("Hello");
    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(40, 30, 30) * Time.deltaTime);

    }
}
