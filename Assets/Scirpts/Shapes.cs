using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    // ENCAPSULATION
    private string shapeName;
    private Color shapeColor;
    public  string ShapeName
    {
        set { shapeName = value; }
        get { return shapeName; }
    }
    public Color ShapeColor
    {
        get { return shapeColor; }
        set
        {
            shapeColor = value;
            GetComponent<Renderer>().material.color = value;
        }
    }
    // POLYMORPHISM
    private void OnMouseDown()
    {
        DoAction(); 
    }

    // ABSTRACTION
      public abstract void DoAction();

}
