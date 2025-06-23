using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
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
    private void OnMouseDown()
    {
        DoAction(); 
    }

    
      public abstract void DoAction();

}
