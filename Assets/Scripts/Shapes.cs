using UnityEngine;

public class Shapes
{
    public virtual void Draw()
    {
        Debug.Log("Drawing shape");
    }

    public virtual float GetArea()
    {
        return 0f;
    }

    public virtual Color GetColor()
    {
        return Color.black;
    }
}