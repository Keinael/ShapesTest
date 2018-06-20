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
            Debug.Log("Shape: " + shape.GetType() + ". Area = " + shape.GetArea() + ". Color: " + shape.GetColor() +
                      ". Additional info: ");
        }
    }
}