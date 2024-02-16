using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private int Height = 256;
    private int Width = 256;  
    private int[,] gridArray;

    void GridGenerate()
    {
        gridArray = new int[Width, Height];
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                gridArray[i, j] = i;
            }
        }
    }
    void Start()
    {
        GridGenerate();
    }
}
    