using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1Controller : MonoBehaviour
{
    float horizonatal_mvmt;
    //float vertical;
    public float jump;
    public float speed;
    public float life;
    public Rigidbody2D charac;
    public int MaxJumps;
    int JumpCount = 0;
    public string scene;



    // Start is called before the first frame update
    void Start()
    {
        JumpCount = MaxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        horizonatal_mvmt = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");
        charac.velocity = new Vector2(speed * horizonatal_mvmt, charac.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            if( JumpCount > 0)
            {
                Jump();
            }
            
        }
    }
    public void Jump()
    { 
        
        //if (charac.position.y > 6f)
        //{
            //charac.position = charac.position;
            //JumpCount -= 1;
            
        //}
        //else
        //{
        charac.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        JumpCount -= 1;

        //}
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            JumpCount = MaxJumps;
        }
    }

    public void Load(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        SpeedPowerup moreSpeed = col.gameObject.GetComponent<SpeedPowerup>();
        LifePowerUp moreLife = col.gameObject.GetComponent<LifePowerUp>();
        LifeDecrease lessLife = col.gameObject.GetComponent<LifeDecrease>();

        if (moreSpeed != null){speed += moreSpeed.speedIncrease; Destroy(moreSpeed.gameObject);}

        if (moreLife != null){life -= moreLife.lifeIncrease; Destroy(moreLife.gameObject);}

        if (lessLife != null)
        {
            if (life == 0 || life - lessLife.lifeDecrease<=0)
            {
                Destroy(charac.gameObject);
                Load(scene);
                //end game
                
            }
            else
            {
                life -= lessLife.lifeDecrease; Destroy(lessLife.gameObject);
                if (horizonatal_mvmt > 0)
                {
                    charac.position = new Vector2(charac.position.x - 3, charac.position.y);
                }
                else
                {
                    charac.position = new Vector2(charac.position.x + 3, charac.position.y);
                }

            }
            
        }

       

    }

}
