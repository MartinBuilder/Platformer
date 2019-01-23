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

            case "PickUp":
                if (Input.GetMouseButtonDown(1)) { hold = null; }
                if (hold != null) { hold.transform.position = temp.transform.position; }break;
        }
       
    }
}
