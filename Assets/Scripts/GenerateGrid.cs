using UnityEngine;
using System.Collections;

public class GenerateGrid : MonoBehaviour 
{
	public GameObject[,] grid;

	public void Generate(int x, int y)
	{
		grid = new GameObject[x,y];

		for(var i = 0; i < x; i++)
		{
			for(var j = 0; j < y; j++)
			{
				var go = new GameObject();
				go.transform.parent = this.transform.FindChild("GridObjects").transform;
				go.name = i + ", " + j;
				go.transform.localPosition = new Vector3(i, 0, j);
				go.transform.localScale = new Vector3(1,0.1f,1);
				var bc = go.AddComponent("BoxCollider") as BoxCollider;
				bc.size = new Vector3(1, 0.25f, 1);
				go.AddComponent<MouseClick>();
				go.tag = "GridSquare";
				grid[i,j] = go;
			}
		}
	}

	public void Clear()
	{
		foreach(var gs in GameObject.FindGameObjectsWithTag("GridSquare"))
		{ 
			DestroyImmediate(gs);
		}
	}
}
