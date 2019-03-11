using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    private Transform bar;
    private float health;
    
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        P1Controller p1controller = Player.GetComponent<P1Controller>();
        var health = p1controller.life;

        bar = transform.Find("Bar");
        health /= 10.0f; // change if changing health
        bar.localScale = new Vector3(health, 1f);
    }
}
