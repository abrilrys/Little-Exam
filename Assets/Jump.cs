
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump: MonoBehaviour
{
    public float upForce = 500f;
    public int player_num;
    public float speed=4;
    private bool isDead = false;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            rb2d.AddForce(new Vector2(speed, 0));
            if (Input.GetKeyDown(KeyCode.Space) && player_num == 0) 
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(speed, upForce));
            }
        }
        
    }

    void OnCollisionEnter2D()
    {
       

        if (isDead == false && player_num == 0)
        {
            rb2d.velocity = Vector2.zero;
            isDead = true;
            GameControl.instance.Died();
        }

      
    }

}

