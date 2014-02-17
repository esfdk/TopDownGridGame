using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

[CustomEditor(typeof(CreateTokens))]
public class CreateTokensEditor : Editor 
{
	int xPosition = 0;
	int yPosition = 0;
	string text = "";
	Color textColor = Color.red;

	public override void OnInspectorGUI()
	{
		CreateTokens createTokensScript = (CreateTokens)target;
		
		DrawDefaultInspector();
		
		xPosition = EditorGUILayout.IntField("x position:", xPosition);
		yPosition = EditorGUILayout.IntField("y position:", yPosition);
		text = EditorGUILayout.TextField("Token text:", text);
		textColor = EditorGUILayout.ColorField ("Text Color:", textColor);
		
		// Create a button for generating the grid.
		GUILayout.BeginHorizontal();
		if(GUILayout.Button("Create Token", GUILayout.Height(30)))
		{
			createTokensScript.Create(xPosition, yPosition, text, textColor);
		}
		GUILayout.EndHorizontal();
	}
}
