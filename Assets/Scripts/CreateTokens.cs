using UnityEngine;
using System.Collections;

public class CreateTokens : MonoBehaviour 
{
	public GameObject tokenPrefab;

	public void Create(int x, int y, string text, Color textColor)
	{
		var go = (Instantiate(tokenPrefab) as GameObject).transform;
		//Basic stuff
		go.gameObject.name = text;
		go.parent = this.transform.Find("Tokens").transform;
		go.localPosition = new Vector3 (x, 0, y);
		go.localScale = new Vector3 (1, 1, 0.1F);

		//Text mesh stuff
		var textComponent = go.gameObject.GetComponent("TextMesh") as TextMesh;
		textComponent.text = text;
		textComponent.color = textColor;
	}
}
