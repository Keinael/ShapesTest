using UnityEngine;

public class RightTriangle : Shapes
{
    public float SideA { get; private set; }
    public float SideB { get; private set; }

    public float Hypotenuse
    {
        get { return Mathf.Sqrt(SideA * SideA + SideB * SideB); }
    }

    private Color _color;

    public RightTriangle(float sideA, float sideB, Color color)
    {
        SideA = sideA;
        SideB = sideB;
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