using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClouds : MonoBehaviour {

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cloud")
        {
            Destroy(other.gameObject);
        }
    }
}
