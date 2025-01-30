using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
  //Variable for the speed of the planet
           float speed = .01f;
    // Start is called before the first frame update
    void Start()
      {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }

}


