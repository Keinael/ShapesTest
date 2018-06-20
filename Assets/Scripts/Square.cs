using UnityEngine;

public class Square : Shapes
{
    public float SideLength;
    
    private Color _color;

    public Square(float sideLength, Color color)
    {
        SideLength = sideLength;
        _color = color;
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
        return _color;
    }
}