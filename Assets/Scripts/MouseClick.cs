using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour 
{
	private bool selected;

	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0))
		{
			var us = GameObject.Find("Main Camera").GetComponent<UniversalScript>() as UniversalScript;

			if(this.tag == "Token")
			{
				us.SelectedObject = this.gameObject;
			}
			else if(this.tag == "GridSquare")
			{
				if(us.SelectedObject != null)
				{
					var p = this.gameObject.transform.position;
					us.SelectedObject.transform.position = new Vector3(p.x, p.y + 0.1f, + p.z);
					us.SelectedObject = null;
				}
			}
		}
	}
}
