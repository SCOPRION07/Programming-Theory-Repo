using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shapes
{
    // Start is called before the first frame update
    void Start()
    {
         ShapeName = "Cylinder";
        ShapeColor = Color.green;
    }

    void Update()
    {
        transform.Rotate(  0f , 0f, 50 * Time.deltaTime);
    }
    // Update is called once per frame
    public override void DoAction()
    {
        Debug.Log("Cylinder");


    }
}
