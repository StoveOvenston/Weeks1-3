using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
  //Variable for the speed of the planet
           float speed = .01f;
           // boolean for warpdrive
    bool warp = false;
    // Start is called before the first frame update
    void Start()
      {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if statement to switch warp on and off
        if (Input.GetKeyDown(KeyCode.Space)) {
            warp = !warp;
        }
    //Position of the planet    
    Vector3 pos = transform.position;
    //Moves the star across the screen    
    pos.x -= speed;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
       //Detects if the planet go off the screen and then loops it back
        if(pos.x < -20)
        {
           pos.x = 30;
        }
        transform.position = pos;
    
        //changes speed depending on warp
        if (warp == true) {
        speed = .05f;
    }
    else {
        speed = .01f;
    }
     }
}




