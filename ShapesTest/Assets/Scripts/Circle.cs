using UnityEngine;

public class Circle : Shapes
{
    public float Radius;
    public Color Color;

    public Circle(float radius, Color color)
    {
        Radius = radius;
        Color = color;
    }

    public override float[] GetAdditionalInfo()
    {
        return new[] {Radius};
    }

    public override void Draw()
    {
        Debug.Log("Circle is drawing");
    }

    public override float GetArea()
    {
        return Mathf.PI * (Radius * 2);
    }

    public override Color GetColor()
    {
        return Color;
    }
}