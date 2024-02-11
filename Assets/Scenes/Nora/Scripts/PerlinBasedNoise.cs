using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinBasedNoise : MonoBehaviour
{
    [SerializeField]
    private int width = 256;
    [SerializeField]
    private int height = 256;
    [SerializeField]
    private float scale = 10.0f;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = TextureFill();
    }

    private Texture2D TextureFill()
    {
        Texture2D texture = new Texture2D(width, height, TextureFormat.ARGB32, false);
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Color color = PerlinColor(i, j);
                texture.SetPixel(i, j, color);
            }
        }
        texture.Apply();
        return texture;
    }

    private Color PerlinColor(int i,  int j)
    {
        float x = (float)i/width * scale;
            float y = (float)j / height * scale;

        float rgb = Mathf.PerlinNoise(x, y);
        return new Color(rgb, rgb, rgb);
        
    }
}
