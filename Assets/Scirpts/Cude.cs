using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cude : Shapes
{
    // Start is called before the first frame update
    void Start()
    {
         ShapeName = " Cube ";
        ShapeColor = Color.red;
    }

    void Update()
    {
        transform.Rotate(-50 * Time.deltaTime, 0f, 0f);
    }
    // Update is called once per frame
    public override void DoAction()
    {
        Debug.Log(" Cube ");
        

    }
}
