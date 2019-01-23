using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoingController : MonoBehaviour {
    [SerializeField] private GameObject temp;
    public GameObject hold;
    public string tag;
  
	void Update () {

        Doing();
    }


void Doing()
    {

        switch (tag)
        {
            case "ElevatorUP":
                GameObject.FindWithTag("Elevator").GetComponent<Renderer>().material.color = Color.green;
                GameObject.Find("Elevator").transform.Translate(Vector3.up * Time.deltaTime);
                GameObject.Find("Player").transform.Translate(Vector3.up * Time.deltaTime); break;
            case "ElevatorDown":
                GameObject.FindWithTag("Elevator").GetComponent<Renderer>().material.color = Color.red;
                GameObject.Find("Elevator").transform.Translate(Vector3.down * Time.deltaTime);
                GameObject.Find("Player").transform.Translate(Vector3.down * Time.deltaTime); break;
            case "PickUp":
                if (Input.GetMouseButtonDown(1)) { hold = null; }
                if (hold != null) { hold.transform.position = temp.transform.position; }break;
        }
       
    }
}
