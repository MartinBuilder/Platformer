using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float Mx = 0.0f;
    private float My = 0.0f;

    public GameObject Cam;
    
    void Update()
    {
        Mx = Mathf.Min(90, Mathf.Max(-90, Mx + Input.GetAxis("Mouse Y")));
        My -= speedV * Input.GetAxis("Mouse X")/2;

        transform.eulerAngles = new Vector3(0, -My, 0.0f);
        Cam.transform.rotation = Quaternion.Euler(-Mx, -My, 0.0f);
        
        Cursor.visible = false;
    }
}