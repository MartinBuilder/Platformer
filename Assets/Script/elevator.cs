using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {
    public static string tag;
 
    private void OnCollisionStay(Collision col)
    {
        switch (tag)
        {
            case "ElevatorUP":
                GameObject.FindWithTag("Elevator").GetComponent<Renderer>().material.color = Color.green;
                transform.Translate(Vector3.up * Time.deltaTime);
                col.transform.Translate(Vector3.up * Time.deltaTime); break;
            case "ElevatorDown":
                GameObject.FindWithTag("Elevator").GetComponent<Renderer>().material.color = Color.red;
                transform.Translate(Vector3.down * Time.deltaTime);
                col.transform.Translate(Vector3.down * Time.deltaTime); break;
        }
    }

}
