using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int positivesToPlace = 18;
    public int negativesToPlace = 18;

    private Tile[] tiles;

    void Start()
    {
        tiles = GetComponentsInChildren<Tile>();
        AssignValues();
    }

    void AssignValues()
    {
        List<int> values = new List<int>();

        for (int i = 0; i < positivesToPlace; i++)
            values.Add(2);

        for (int i = 0; i < negativesToPlace; i++)
            values.Add(-2);

        // Shuffle (Fisher-Yates)
        for (int i = values.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = values[i];
            values[i] = values[j];
            values[j] = temp;
        }

        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].Id = i;     

            int v = values[i];
            tiles[i].SetValue(v);

            if (v > 0) positiveCount++;
            else negativeCount++;
        }

        Debug.Log($"RESULT: {positiveCount} positive tiles, {negativeCount} negative tiles.");
    }
}
