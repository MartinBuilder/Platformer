using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float Mx = 0.0f;
    private float My = 0.0f;
    public GameObject Cam;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Mx += speedH * Input.GetAxis("Mouse X")/2;
        My -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0, Mx, 0.0f);
       Cam.transform.rotation = Quaternion.Euler(My, Mx, 0.0f);

        Cursor.visible = false;

    }


}