using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
   
    private DoingController Do;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Do = GameObject.Find("DoingController").GetComponent<DoingController>();
        
    }
    void FixedUpdate()
    {
      
 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, fwd, out hit))
            {
                if (hit.collider != null)
                {

                    switch (hit.collider.gameObject.tag) { 
                        case "PickUp": Do.hold = hit.collider.gameObject; Do.tag = hit.collider.tag; break;
                        case "Elevator":
                            if (GameObject.FindWithTag("Elevator").GetComponent<Renderer>().material.color != Color.green)
                            {
                                elevator.tag = hit.collider.tag + "UP";
                                Debug.Log(hit.collider.tag + "UP");
                            }
                            else{ elevator.tag = hit.collider.tag + "Down"; }break;}

              
                }
            }
                    
        }
    }
}