using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour {
    Renderer rend;
    private float range = 2;
    public bool IsPressed = false;

    void Start ()
    {
        
        rend = GameObject.FindWithTag("Button").GetComponent<Renderer>();
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward, out hit, range ))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider.tag == "Button")
                {
                    Debug.Log("clicked");
                    rend.material.color = Color.green;
                    IsPressed = true;
                }
            }
        }
	}
}
