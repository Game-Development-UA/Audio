using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform doorPivot;

    // Update is called once per frame
    //void OnCollisionEnter2D(Collider2D col)
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            doorPivot.Rotate(0f,80f, 0f);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            doorPivot.rotation = Quaternion.identity;
        }
    }

}


