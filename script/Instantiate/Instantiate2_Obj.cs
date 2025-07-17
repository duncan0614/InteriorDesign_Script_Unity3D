using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Instantiate2_Obj : MonoBehaviour {

	public GameObject Instantiate_Position;
	public GameObject abc;



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


	void Start () {

		this.GetComponent<Button> ().onClick.AddListener (Clickme);

	}




	void Clickme()
	{


	Instantiate (abc, Instantiate_Position.transform.position,abc.transform.rotation);

	}

	void Update()
	{

		//if (CheckGuiRaycastObjects()) return;
		// Debug.Log(EventSystem.current.gameObject.name);
		//if (Input.GetMouseButtonDown(0)){
		//if(Input.GetKey("d")==true)

		//{
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//RaycastHit hit;

				//if (Physics.Raycast (ray, out hit)) {
					//do some thing

					//if(hit.transform.tag != "object"){return;}

					//if (hit.collider.gameObject.transform.tag == "plane") {
						//return;
					//}
				
					//Destroy (hit.collider.gameObject);

				//}
				//}

			//}

	}


}
