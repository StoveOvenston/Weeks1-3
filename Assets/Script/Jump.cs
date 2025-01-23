using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public AnimationCurve jump;
    [Range(0,1)]
    float jumpSpeed = 10f;
    public float t; 
    Boolean isJumping = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
        if (isJumping == true)
        {
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
            }
            transform.position += transform.up * jumpSpeed * Time.deltaTime;
            if (t == 0) ;
            isJumping = false;
        }
        }
        
    }

