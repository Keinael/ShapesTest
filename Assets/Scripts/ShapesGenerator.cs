using System.Collections.Generic;
using UnityEngine;

public class ShapesGenerator
{
    public List<Shapes> GenerateRandomShapeList()
    {
        var randomShapesList = new List<Shapes>();
        var listCount = Random.Range(1, 20);
        for (var i = 0; i < listCount; i++)
        {
            randomShapesList.Add(GetRandomShape());
        }

        return randomShapesList;
    }

    private Shapes GetRandomShape()
    {
        Shapes shape = null;

        switch (Random.Range(1, 5))
        {
            case 1:
                shape = new Square(Random.Range(1f, 10f), GetRandomColor());
                break;
            case 2:
                shape = new Circle(Random.Range(1f, 10f), GetRandomColor());
                break;
            case 3:
                shape = new RightTriangle(Random.Range(1f, 10f), Random.Range(1f, 10f), GetRandomColor());
                break;
            case 4:
                shape = new Trapeze(Random.Range(1f, 10f), Random.Range(1f, 10f), Random.Range(1f, 5f),
                    GetRandomColor());
                break;
            default:
                Debug.Log("Shape is not generated");
                break;
        }

        return shape;
    }

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}