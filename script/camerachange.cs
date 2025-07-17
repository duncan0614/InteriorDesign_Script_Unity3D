using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour
{

    public GameObject camera1, camera2, camera3, camera4;
    public GameObject obj;
    void Awake()
    {
        obj.SetActive(true);
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey("2") == true)
        {
			obj.SetActive(true);
            //若是按下鍵盤的z則切換成第二部攝影機
            camera1.SetActive(false);
			camera2.SetActive(true);
            camera3.SetActive(false);
            camera4.SetActive(false);

        }
        else if (Input.GetKey("3") == true)
        {
					obj.SetActive(true);
            //若是按下鍵盤的3則切換成第三部攝影機
            camera1.SetActive(false);
            camera2.SetActive(false);
			camera3.SetActive(true);
            camera4.SetActive(false);
        }
        else if (Input.GetKey("4") == true)
        {
					obj.SetActive(true);
            //若是按下鍵盤的4則切換成第四部攝影機
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
					camera4.SetActive(true);
        }
        else if (Input.GetKey("1") == true)
        {
					obj.SetActive(true);
            //若是按下鍵盤的1則切換成第四部攝影機
					camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }
    }
}