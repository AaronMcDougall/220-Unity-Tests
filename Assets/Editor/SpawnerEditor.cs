using System;
using System.Collections;
using System.Collections.Generic;
using Codice.CM.SEIDInfo;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TwoDCubeSpawner))]
public class SpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Respawn"))
        {
            ((TwoDCubeSpawner)target)?.GenerateGrid();
        }

        if (GUILayout.Button("Clear"))
        {
            ((TwoDCubeSpawner)target)?.ClearGrid();
        }
    }
}
