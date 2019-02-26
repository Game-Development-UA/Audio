using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood_Spawn : MonoBehaviour
{

    
    public ParticleSystem ps;
    public Transform player;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Hazard")
        {
            Instantiate(ps, player.position, player.rotation);
        }
    }









}




