using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{

	public float sensitivityX = 10f;
	public float sensitivityY = 10f;
	public float movementspeed;
	public float ScaleSpeed = 10.0f;

	void Update()
	{
		//攝影機旋轉
		if (Input.GetMouseButton(1))
		{
			float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
			transform.Rotate(0, rotationX, 0);

			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			transform.Rotate(-rotationY, 0, 0);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			if (transform.position.y < addfloor.limithigh)
			{

				float horizontalInput = Input.GetAxis("Horizontal");
				float verticalInput = Input.GetAxis("Vertical");
				transform.position = transform.position + new Vector3(0 , movementspeed , 0);
			}
		}

		else if (Input.GetKey(KeyCode.DownArrow))
		{
			if (transform.position.y > addfloor.limitlow)
			{

				float horizontalInput = Input.GetAxis("Horizontal");
				float verticalInput = Input.GetAxis("Vertical");
				transform.position = transform.position + new Vector3( 0 , -movementspeed , 0);
			}
		}
		if (transform.localEulerAngles.z != 0)
		{
			float rotX = transform.localEulerAngles.x;
			float rotY = transform.localEulerAngles.y;
			transform.localEulerAngles = new Vector3(rotX, rotY, 0);
		}


		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			Camera.main.transform.Translate(0, 0, -1 * ScaleSpeed);
		}

		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			Camera.main.transform.Translate(0, 0, 1 * ScaleSpeed);
		}

	}
}