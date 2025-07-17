using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .UI ;
using UnityEngine.EventSystems;

public class worldspacefllow : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	bool CheckGuiRaycastObjects()
	{
		// PointerEventData eventData = new PointerEventData(Main.Instance.eventSystem);

		PointerEventData eventData = new PointerEventData(EventSystem.current);
		eventData.pressPosition = Input.mousePosition;
		eventData.position = Input.mousePosition;

		List<RaycastResult> list = new List<RaycastResult>();
		// Main.Instance.graphicRaycaster.Raycast(eventData, list);
		EventSystem.current.RaycastAll(eventData, list);
		//Debug.Log(list.Count);
		return list.Count > 0;
	}

	void Update()
	{
		if (CheckGuiRaycastObjects()) return;
		// Debug.Log(EventSystem.current.gameObject.name);
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				//do some thing



			}
		}
	}
}