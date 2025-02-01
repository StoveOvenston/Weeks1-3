using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve bounce;
  
    public Vector2 start;
    public Vector2 end;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
         transform.position = Vector2.Lerp(start, end, bounce.Evaluate(t));
    }
}
