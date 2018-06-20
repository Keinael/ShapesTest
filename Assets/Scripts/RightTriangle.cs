using UnityEngine;

public class RightTriangle : Shapes
{
    public float SideA;
    public float SideB;
    public float Hypotenuse;
    
    private Color _color;

    public RightTriangle(float sideA, float sideB, float hypotenuse, Color color)
    {
        SideA = sideA;
        SideB = sideB;
        Hypotenuse = hypotenuse;
        _color = color;
    }

    public override void Draw()
    {
        Debug.Log("Triangle is drawing");
    }

    public override float GetArea()
    {
        return SideA * SideB * 0.5f;
    }

    public override Color GetColor()
    {
        return _color;
    }
}