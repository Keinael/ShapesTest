using UnityEngine;

public class Trapeze : Shapes
{
    public float BasisA { get; private set; }
    public float BasisB { get; private set; }
    public float Height { get; private set; }

    private Color _color;

    public Trapeze(float basisA, float basisB, float height, Color color)
    {
        BasisA = basisA;
        BasisB = basisB;
        Height = height;
        _color = color;
    }

    public override void Draw()
    {
        Debug.Log("Trapeze is drawing");
    }

    public override float GetArea()
    {
        return ((BasisA + BasisB) * Height) / 2;
    }

    public override Color GetColor()
    {
        return _color;
    }
}