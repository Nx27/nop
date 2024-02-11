using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private int height;
    private int width;  
    private int[,] gridArray;

    public Grid(int height, int width)
    {
        this.height = height;
        this.width = width;
        gridArray = new int[width, height];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    