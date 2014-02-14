using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

[CustomEditor(typeof(GenerateGrid))]
public class GenerateGridEditor : Editor
{
	int hSquares = 1;
	int vSquares = 1;
	public override void OnInspectorGUI()
	{
		GenerateGrid generateGridScript = (GenerateGrid)target;

		DrawDefaultInspector();

		hSquares = EditorGUILayout.IntField("Horizontal squares:", hSquares);
		vSquares = EditorGUILayout.IntField("Vertical squares:", vSquares);

		// Create a button for generating the grid.
		GUILayout.BeginHorizontal();
		if(GUILayout.Button("Generate Grid", GUILayout.Height(30)))
		{
			generateGridScript.Generate(hSquares, vSquares);
		}
		GUILayout.EndHorizontal();

		// Create a button for clearing the grid.
		GUILayout.BeginHorizontal();
		if(GUILayout.Button("Clear Grid", GUILayout.Height(30)))
		{
			generateGridScript.Clear();
		}
		GUILayout.EndHorizontal();
	}
}
