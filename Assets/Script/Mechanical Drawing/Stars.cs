using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    //Variable for the speed of the stars
           float speed = .01f;
    // Start is called before the first frame update
    void Start()
      {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Position of the stars    
    Vector3 pos = transform.position;
    //Moves the star across the screen    
    pos.x -= speed;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
       //Detects if the stars go off the screen and then loops them back
        if(screenPos.x < -14)
        {
           pos.x = 14;
        }
        transform.position = pos;
    }

}

