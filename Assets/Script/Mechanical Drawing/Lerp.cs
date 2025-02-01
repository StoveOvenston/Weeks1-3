using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [Range(0, 4)]
    public float t;
    public AnimationCurve bounce;
  bool goingUp = true;
 
    public Vector2 start;
    public Vector2 end;
    // Start is called before the first frame update
    void Start()
    {
       // MAKE POSITIONS FOR START AND end
       start = new Vector2(transform.position.x, 0.57f);
       //set end position
       end = new Vector2(transform.position.x, 3f);
    t = 0;
    }


    // Update is called once per frame
    void Update()
    {
        //Makes a variable that is able to switch the ship between going up and down. 
    if (goingUp == true) {   
    t += Time.deltaTime; 
         transform.position = Vector2.Lerp(start, end, t);
    }
    else if (goingUp == false) {
        t += Time.deltaTime;
        transform.position = Vector2.Lerp(end,start,t);
    }
         // Make t a timer so the animation can loop
        //Swaps boolean at specific points to let the ship "bounce"
         if( t >= 2) {
         t = 0;   
         goingUp = !goingUp;
         }
    }
}
