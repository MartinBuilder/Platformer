using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {

     private GameObject Camera;
	
	void Start () {
        Camera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (Camera.GetComponent<buttonPress>().IsPressed == true && transform.position.y <= 10) 
        {
            Debug.Log("test");
             transform.Translate(Vector3.up * Time.deltaTime);
        }
	}
}
