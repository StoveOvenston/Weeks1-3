using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [Range(0, 4)]
    public float t;
    public AnimationCurve bounce;
  
    public Vector2 start;
    public Vector2 end;
    // Start is called before the first frame update
    void Start()
    {
       // MAKE POSITIONS FOR START AND end
       start = transform.position;
       //set end position
       end = transform.position;
    t = 0;
    }


    // Update is called once per frame
    void Update()
    {
       t += Time.deltaTime; 
         transform.position = Vector2.Lerp(start, end, bounce.Evaluate(t));
         // Make t a timer so the animation can loop
         if( t > 4) {
             t = 0;
             start = transform.position;
         }
    }
}
