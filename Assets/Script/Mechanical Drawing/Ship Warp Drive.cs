using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWarpDrive : MonoBehaviour
{
// set a float value for the speed of the ship entering warp speed   
float ftlDriveSpeed = 1f;
//have a boolean value for the warp drive being on and off    
bool warpDriveOn = false;
//have another bool for direction
bool exitWarp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
    if (Input.GetKeyDown(KeyCode.Space))
    {
         
    warpDriveOn = !warpDriveOn;
    
    }
  
    if (warpDriveOn == true)
    {
        ftlDriveSpeed = 2;
        pos.x += ftlDriveSpeed;
       transform.position = pos;
        if(pos.x >= 0) {
            ftlDriveSpeed = 0;
            warpDriveOn = false;
        }
    }
   
    if (pos.x >= 0 && Input.GetKeyDown(KeyCode.Space) ) {
   exitWarp = true;
   }
   if (exitWarp == true) {
   ftlDriveSpeed = 1f;
        pos.x -= ftlDriveSpeed;
        transform.position = pos;
    
        if(pos.x < -5.85) {
          ftlDriveSpeed = 0;
          exitWarp = false;
        }
    }
    
    
    
    
    }
}
