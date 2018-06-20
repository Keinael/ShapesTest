using UnityEngine;

public class Trapeze : Shapes
{
    public float SideA;
    public float SideB;
    public float Height;

    public Color Color;

    public Trapeze(float sideA, float sideB, float height, Color color)
    {
        SideA = sideA;
        SideB = sideB;
        Height = height;
        Color = color;
    }

    public override float[] GetAdditionalInfo()
    {
        return new[] {SideA, SideB, Height};
    }

    public override void Draw()
    {
        Debug.Log("Trapeze is drawing");
    }

    public override float GetArea()
    {
        return ((SideA + SideB) * Height) / 2;
    }

    public override Color GetColor()
    {
        return Color;
    }
}