using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeOne : MonoBehaviour
{
    float speed = .01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
        if(screenPos.x < 0 || screenPos.x> Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }

}
