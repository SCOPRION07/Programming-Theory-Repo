using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes
{
    // Start is called before the first frame update
    void Start()
    {
        ShapeName = " Sphere";
        ShapeColor = Color.blue;
    }

    public override void DoAction()
    {
        Debug.Log(" Sphere");
        // transform.Translate(Vector3.left * Time.deltaTime*10);
        
    }
}
