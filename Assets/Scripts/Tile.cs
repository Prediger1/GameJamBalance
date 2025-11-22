using UnityEngine;

public class Tile : MonoBehaviour
{
    public int Id;
    public int Value;

    public bool IsConsumed = false;

    public void SetValue(int v)
    {
        Value = v;
    }
}
