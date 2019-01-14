using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float Mx = 0.0f;
    private float My = 0.0f;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Mx += speedH * Input.GetAxis("Mouse X");
        My -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(My, Mx, 0.0f);
    //player.transform.rotation = Quaternion.Euler(0, Mx, 0.0f);

        Cursor.visible = false;

    }


}