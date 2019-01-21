using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    [SerializeField] private GameObject temp;
    private GameObject hold; 
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        if (hold != null)
        {
            hold.transform.position = temp.transform.position;
        }
        if (Input.GetMouseButtonDown(1))
        {hold = null; }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, fwd, out hit))
            {
                if (hit.collider != null)
                {
                    print("pickup");

                    if (hit.collider.gameObject.tag == "Finish")
                    {
                        hold = hit.collider.gameObject;

                    }
                }
            }
        }
    }
}