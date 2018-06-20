using UnityEngine;

public class Square : Shapes
{
    public float SideLength;
    public Color Color;

    public Square(float sideLength, Color color)
    {
        SideLength = sideLength;
        Color = color;
    }

    public override float[] GetAdditionalInfo()
    {
        return new[] {SideLength};
    }

    public override void Draw()
    {
        Debug.Log("Square is drawing");
    }

    public override float GetArea()
    {
        return SideLength * 2;
    }

    public override Color GetColor()
    {
        return Color;
    }
}