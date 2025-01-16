using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHand : MonoBehaviour
{
 //hour hand speed
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hour hand
        Vector3 rot = transform.eulerAngles;
        rot.z -= speed;
        transform.eulerAngles = rot; 
    }
}
