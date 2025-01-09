using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Circlemouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mousepos;
    }
}
