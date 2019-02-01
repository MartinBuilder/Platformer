using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieControler : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public GameObject DeathPlain;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == DeathPlain)
        {
            transform.position = new Vector3(x, y, z);
        }
    }
}
