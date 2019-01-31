using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieControler : MonoBehaviour
{

    public GameObject DeathPlain;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == DeathPlain)
        {
            transform.position = new Vector3(58, 19, 48);
        }
    }
}
