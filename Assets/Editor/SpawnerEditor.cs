using System;
using System.Collections;
using System.Collections.Generic;
using Codice.CM.SEIDInfo;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeSpawner))]
public class SpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Respawn"))
        {
            ((CubeSpawner)target)?.GenerateGrid();
        }

        if (GUILayout.Button("Clear"))
        {
            ((CubeSpawner)target)?.ClearGrid();
        }
    }
}
