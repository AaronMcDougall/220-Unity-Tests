using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ThreeDGridSpawner))]
public class GridSpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Respawn"))
        {
            ((ThreeDGridSpawner)target)?.GenerateGrid();
        }

        if (GUILayout.Button("Clear"))
        {
            ((ThreeDGridSpawner)target)?.ClearGrid();
        }
    }
}
