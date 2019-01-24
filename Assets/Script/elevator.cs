using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {
    public static string tag;
    private Renderer button;
    private void Start()
    {
        button = GameObject.FindWithTag("Elevator").GetComponent<Renderer>();

    }
    private void OnCollisionStay(Collision col)
    {
        switch (tag)
        {
            case "ElevatorUP":
              
                if (transform.position.y <= 4 ){ button.material.color = Color.green;
                transform.Translate(Vector3.up * Time.deltaTime);
                col.transform.Translate(Vector3.up * Time.deltaTime);}break;
            case "ElevatorDown":
                if(transform.position.y >= 0) { button.material.color = Color.red;
                transform.Translate(Vector3.down * Time.deltaTime);
                col.transform.Translate(Vector3.down * Time.deltaTime);} break;
        }
    }
   

}
