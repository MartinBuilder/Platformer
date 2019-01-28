using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractionController : MonoBehaviour
{

    private GameObject hold;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1)) { hold = null; }
        if (hold != null) { hold.transform.position = this.gameObject.transform.GetChild(0).transform.position;}
       

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, fwd, out hit))
            {   

                switch (hit.collider.gameObject.tag) { 
                        case "PickUp": hold = hit.collider.gameObject;  break;
                        case "UpDown": case "LeftRight": hit.transform.parent.GetComponent<PlatformMovementController>().auto = false; hit.transform.parent.GetComponent<PlatformMovementController>().tag = hit.collider.tag; hit.collider.GetComponent<Renderer>().material.color = Color.green; break; 
                }

              
                
            }
                    
        }
    }
}