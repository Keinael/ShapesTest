using UnityEngine;

public class RightTriangle : Shapes
{
    public float SideA;
    public float SideB;
    public float Hypotenuse;
    public Color Color;

    public RightTriangle(float sideA, float sideB, float sideC, float hypotenuse, Color color)
    {
        SideA = sideA;
        SideB = sideB;
        Hypotenuse = hypotenuse;
        Color = color;
    }

    public override float[] GetAdditionalInfo()
    {
        return new[] {SideA, SideB, Hypotenuse};
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
        return Color;
    }
}