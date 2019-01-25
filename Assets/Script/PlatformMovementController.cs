using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementController : MonoBehaviour {

    public string tag;
    private string Go;
    private bool auto;
    private GameObject platform;
    private void Start()
    {
        platform = transform.parent.gameObject;
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
                if (Go == "UP") { platform.transform.Translate(Vector3.up * Time.deltaTime); col.transform.Translate(Vector3.up * Time.deltaTime); }
                else if (Go == "DOWN") { platform.transform.Translate(Vector3.down * Time.deltaTime); col.transform.Translate(Vector3.down * Time.deltaTime); }
                break;
            case "LeftRight":
                if (Go == "LEFT") { platform.transform.Translate(Vector3.left * Time.deltaTime); }
                else if (Go == "RIGHT") { platform.transform.Translate(Vector3.right * Time.deltaTime);  }
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
                    if (Go == "UP") { platform.transform.Translate(Vector3.up * Time.deltaTime); }
                    else if (Go == "DOWN") { platform.transform.Translate(Vector3.down * Time.deltaTime); }
                    break;
            case "LeftRight":
                if (Go == "LEFT") { platform.transform.Translate(Vector3.left * Time.deltaTime);}
                else if (Go == "RIGHT") { platform.transform.Translate(Vector3.right * Time.deltaTime);}
                break;
        }

    }

    void moveTo()
    {
        switch (tag)
        {
            case "UpDown":
                if (Mathf.Round(platform.transform.position.y) == 0f) { Go = "UP"; }
                else if (Mathf.Round(platform.transform.position.y) == 4f) { Go = "DOWN"; }
                break;
            case "LeftRight":
                if (Mathf.Round(platform.transform.position.x) == 6f) { Go = "LEFT"; }
                else if (Mathf.Round(platform.transform.position.x) == 4f) { Go = "RIGHT"; }
                break;
        }

    }

 

    

}



