using UnityEngine;

public class Trapeze : Shapes
{
    public float SideA;
    public float SideB;
    public float Height;

    private Color _color;

    public Trapeze(float sideA, float sideB, float height, Color color)
    {
        SideA = sideA;
        SideB = sideB;
        Height = height;
        _color = color;
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
        return _color;
    }
}