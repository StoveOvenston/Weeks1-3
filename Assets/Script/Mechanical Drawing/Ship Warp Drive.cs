using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWarpDrive : MonoBehaviour
{
// set a float value for the speed of the ship entering warp speed   
float ftlDriveSpeed = 2f;
//have a boolean value for the warp drive being on and off    
bool warpDriveOn = false;
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
    warpDriveOn = true;
    }
    if (warpDriveOn == true)
    {
        pos.x += ftlDriveSpeed;
       transform.position = pos;
        if(pos.x >= 0) {
            ftlDriveSpeed = 0;
        }
    }
}
}