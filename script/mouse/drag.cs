using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class drag : MonoBehaviour
{
	private bool draging = false;
	private Vector3 lastPosition;
	private float distance;

	private void OnMouseDrag()
	{
		Vector3 cursorScreenPosition = Input.mousePosition;
		if (!draging) distance = Vector3.Distance(Camera.main.transform.position, transform.position);
		cursorScreenPosition.z = distance;

		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPosition);
		Vector3 delta = new Vector3();
		if (draging)
		{
			delta = cursorPosition - lastPosition;
		}
		draging = true;

		lastPosition = cursorPosition;

		Debug.Log(cursorPosition);
		delta.y = 0;
		transform.position += delta;
	}
	private void OnMouseUp()
	{
		draging = false;
	}
}