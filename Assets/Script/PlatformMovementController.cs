using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {

    public string tag;
    private string Go;
    private bool auto;
    private GameObject Elevator;
    private void Start()
    {
        Elevator = transform.parent.gameObject;
        auto = false;
    }
  
    private void OnTriggerExit(Collider other)
    {
        print("Exit");
        auto = true;
    
    }
  
    private void OnTriggerStay(Collider col)
    {
    
        auto = false;
        switch (tag)
        {
            case "UpDown":
                if (Go == "UP") { Elevator.transform.Translate(Vector3.up * Time.deltaTime); col.transform.Translate(Vector3.up * Time.deltaTime); }
                else if (Go == "DOWN") { Elevator.transform.Translate(Vector3.down * Time.deltaTime); col.transform.Translate(Vector3.down * Time.deltaTime); }
                break;
            case "LeftRight":
                if (Go == "LEFT") { Elevator.transform.Translate(Vector3.left * Time.deltaTime); col.transform.Translate(Vector3.left * Time.deltaTime); }
                else if (Go == "RIGHT") { Elevator.transform.Translate(Vector3.right * Time.deltaTime); col.transform.Translate(Vector3.right * Time.deltaTime); }
                break;
        }
    }
    private void Update()
    {
        moveTo();
        if (auto){ Run();  }

    }
  
    void Run()
    {
  
            switch (tag)
            {
                case "UpDown":
                    if (Go == "UP") { Elevator.transform.Translate(Vector3.up * Time.deltaTime); }
                    else if (Go == "DOWN") { Elevator.transform.Translate(Vector3.down * Time.deltaTime); }
                    break;
            case "LeftRight":
                if (Go == "LEFT") { Elevator.transform.Translate(Vector3.left * Time.deltaTime);}
                else if (Go == "RIGHT") { Elevator.transform.Translate(Vector3.right * Time.deltaTime);}
                break;
        }

    }

    void moveTo()
    {
        switch (tag)
        {
            case "UpDown":
                if (Mathf.Round(Elevator.transform.position.y) == 0f) { Go = "UP"; }
                else if (Mathf.Round(Elevator.transform.position.y) == 4f) { Go = "DOWN"; }
                break;
            case "LeftRight":
                if (Mathf.Round(Elevator.transform.position.x) == 6f) { Go = "LEFT"; }
                else if (Mathf.Round(Elevator.transform.position.x) == 4f) { Go = "RIGHT"; }
                break;
        }

    }

 

    

}



