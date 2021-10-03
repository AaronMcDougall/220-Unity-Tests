using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ThreeDGridSpawner : MonoBehaviour
{
    public List<GameObject> grid = new List<GameObject>();
    public Collider[] colliders;

    public GameObject cube;

    public float gridSize;
    public float perlinNoise;

    void Start()
    {
        new List<Grid>();
    }

    //spawns blocks
    public void GenerateGrid()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int z = 0; z < gridSize; z++)
                {
                    if (Perlin3D(x * perlinNoise, y * perlinNoise, z * perlinNoise) < 0.5f)
                    {
                        GameObject copy = Instantiate(cube, new Vector3(x, y, z), Quaternion.Euler(0, 0, 0));
                        grid.Add(copy);
                    }
                }
            }
        }
    }

    //clears scene of blocks
    public void ClearGrid()
    {
        foreach (var cube in grid)
        {
            DestroyImmediate(cube, true);
        }

        grid.Clear();
    }

    //get perlin average value
    public static float Perlin3D(float x, float y, float z)
    {
        float ab = Mathf.PerlinNoise(x, y);
        float bc = Mathf.PerlinNoise(y, z);
        float ac = Mathf.PerlinNoise(x, z);

        float ba = Mathf.PerlinNoise(y, x);
        float cb = Mathf.PerlinNoise(z, y);
        float ca = Mathf.PerlinNoise(z, x);

        float abc = ab + bc + ac + ba + cb + ca;
        return abc / 6f;
    }
}