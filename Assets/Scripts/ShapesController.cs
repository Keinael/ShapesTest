using System.Collections.Generic;
using UnityEngine;

public class ShapesController : MonoBehaviour
{
    public ShapesGenerator ShapesGenerator = new ShapesGenerator();
    public List<Shapes> GeneratedList = new List<Shapes>();

    private void Start()
    {
        GeneratedList = ShapesGenerator.GenerateRandomShapeList();

        foreach (var shape in GeneratedList)
        {
            if (shape is Square)
            {
                var square = shape as Square;
                Debug.Log("Shape: " + square.GetType() + ". Area = " + square.GetArea() + ". Color: " +
                          square.GetColor() +
                          ". Additional info: Side length = " + square.SideLength);
            }

            if (shape is Circle)
            {
                var circle = shape as Circle;
                Debug.Log("Shape: " + circle.GetType() + ". Area = " + circle.GetArea() + ". Color: " +
                          circle.GetColor() +
                          ". Additional info: Radius = " + circle.Radius);
            }

            if (shape is Trapeze)
            {
                var trapeze = shape as Trapeze;
                Debug.Log("Shape: " + trapeze.GetType() + ". Area = " + trapeze.GetArea() + ". Color: " +
                          trapeze.GetColor() +
                          ". Additional info: Height = " + trapeze.Height + ", Side a = " + trapeze.BasisA +
                          ", Side b = " + trapeze.BasisB);
            }

            if (shape is RightTriangle)
            {
                var rightTriangle = shape as RightTriangle;
                Debug.Log("Shape: " + rightTriangle.GetType() + ". Area = " + rightTriangle.GetArea() + ". Color: " +
                          rightTriangle.GetColor() +
                          ". Additional info: Hypotenuse = " + rightTriangle.Hypotenuse + ", Side a = " +
                          rightTriangle.SideA + ", Side b = " +
                          rightTriangle.SideB);
            }
        }
    }
}