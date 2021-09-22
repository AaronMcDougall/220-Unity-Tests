using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;

    public List<GameObject> grid = new List<GameObject>();

    public int gridSize;

    public float cubeHeight;
    public float perlinAdjust;
    public float scale;
    

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
        new List<Grid>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GenerateGrid()
    {
        for (int i = 0; i < gridSize; i++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                cubeHeight = Mathf.PerlinNoise(i * perlinAdjust, y * perlinAdjust) * scale;
                Instantiate(cube, new Vector3(i, cubeHeight, y), Quaternion.Euler(0, 0, 0));
                grid.Add(gameObject);
            }
        }
    }

    public void ClearGrid()
    {
        
    }

}
