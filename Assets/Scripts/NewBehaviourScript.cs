﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public float jumpforce;

    public float heroSpeed;

    Animator anim;

    Rigidbody2D rgdBody;

    bool dirtoright = true;

	void Start () {
      
        anim = GetComponent<Animator> ();

        rgdBody = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
       
        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);
         
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rgdBody.AddForce(new Vector2(0f, jumpforce));
            anim.SetTrigger("jump");
        }
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (horizontalMove < 0 && dirtoright)
        {

            Flip();

        }
        if (horizontalMove > 0 && !dirtoright)
        {

            Flip();

        }

        

    }

    void Flip ()
    {

        dirtoright = !dirtoright;

        Vector3 heroScale = gameObject.transform.localScale;

        heroScale.x *= -1;

        gameObject.transform.localScale = heroScale;
    }



}
