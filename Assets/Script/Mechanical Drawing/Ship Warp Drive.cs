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
   //Detects if space is pressed in order to toggle warpdrive on and off
        if (Input.GetKeyDown(KeyCode.Space))
    {
         
    warpDriveOn = !warpDriveOn;
    
    }
   
    if (warpDriveOn == true)
    {
   // Sets the warp drive speed to 3 moving the ship forward     
    ftlDriveSpeed = 3;
        pos.x += ftlDriveSpeed;
       transform.position = pos;
      // detects if the ship has reached 0 and then stops (this stopped working after lerp for some reason?)
       if(pos.x >= 0) {
            ftlDriveSpeed = 0;
            warpDriveOn = false;
        }
    }
   //Detects if ship has met the conditions to exit warp
    if (pos.x >= 0 && Input.GetKeyDown(KeyCode.Space) ) {
   exitWarp = true;
   }
  //Moves the ship backwards and then stops it at it's original coordinates'
   if (exitWarp == true) {
   ftlDriveSpeed = 1f;
        pos.x -= ftlDriveSpeed;
        transform.position = pos;
    
        if(pos.x < -4) {
          ftlDriveSpeed = 0;
          exitWarp = false;
        }
    }
    
    
    
    
    }
}
