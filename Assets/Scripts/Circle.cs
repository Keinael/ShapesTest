using UnityEngine;

public class Circle : Shapes
{
    public float Radius;
    
    private Color _color;

    public Circle(float radius, Color color)
    {
        Radius = radius;
        _color = color;
    }

    public override void Draw()
    {
        Debug.Log("Circle is drawing");
    }

    public override float GetArea()
    {
        return Mathf.Pow(Radius, 2) * Mathf.PI;
    }

    public override Color GetColor()
    {
        return _color;
    }
}