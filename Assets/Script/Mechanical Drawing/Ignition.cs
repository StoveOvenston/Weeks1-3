using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignition : MonoBehaviour
{
//animation curve     
public AnimationCurve engine;
[Range(0,1)]
   // bool for warp
   bool warp = false;
   // float for t
    public float t; 
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // animation curve code
         if (Input.GetKeyDown(KeyCode.Space))
        {
            warp = !warp;
        }
        if (warp == true)
        {
//makes the engine expand while in warp
            t += Time.deltaTime;
            transform.localScale = Vector2.one * engine.Evaluate(t);
            if (t > 4)
            {
                t = 0;
            }
        }
        else {
        //resets engine to default state   
        

        }

    }
}
