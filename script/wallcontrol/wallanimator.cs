using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallanimator : MonoBehaviour
{
	public Animator anime = null;

	/*private void Start()
    {
        anime = this.GetComponent<Animator>();
    }*/

	private void OnMouseDown()
	{
	
			anime.SetTrigger("start");

		

	}



}