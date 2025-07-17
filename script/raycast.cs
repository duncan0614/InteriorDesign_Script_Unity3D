using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{

    private Ray ray;
    //獲取射線資訊
    private RaycastHit hit;

    public GameObject a, b;

    public Animator wallcontrol;

    public Animator floorcontrol;

	public Text PriceText;

	public int Price = 0;

	public int Price2 = 0;

    public Material color1;

    public Material color2;

    public Material color3;

    public Material color4;

    public Material color5;


    void Start()
    {
        
    }

   
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000))
        {
            if (Input.GetMouseButtonDown(0))
            {
                a = hit.collider.gameObject;


                if (hit.collider.gameObject.tag == "wall")
                {
                    Wallanimation();
                }


                if (hit.collider.gameObject.tag == "floor")
                {
                    flooranimation();
                }
            }

            /*if(Input.GetMouseButtonDown(1))
            {
                b = hit.collider.gameObject;            
            }*/
        }

       if (Input.GetKey("z"))
        {
            if (a.tag == "wall")
            {
                a.transform.localScale += new Vector3(0f, 0f, -1f);
            }
        }

        if (Input.GetKey("x"))
        {
            if (a.tag == "wall")
            {
                a.transform.localScale += new Vector3(0f, 0f, 1f);
            }
        }


        if (Input.GetKey("left"))
        {
			if (a.tag != "plane") 
			{
				if (a.tag == "bigobject") 
				{
					a.transform.Rotate (0 , 0, -3);
				}
				else if (a.tag == "middleobject") 
				{
					a.transform.Rotate (0, -3, 0);
				}
				else if (a.tag == "smallobject") 
				{
					a.transform.Rotate (0, 0, -3);
				}
                else
                {
                    a.transform.Rotate(0, -3, 0);
                }
			}
        }

        if (Input.GetKey("right"))
        {
            if (a.tag != "plane")
            {
				if (a.tag == "bigobject") 
				{
					a.transform.Rotate (0, 0, 3);
				}
				else if (a.tag == "middleobject") 
				{
					a.transform.Rotate (0, 3, 0);
				}
				else if (a.tag == "smallobject") 
				{
					a.transform.Rotate (0, 0, 3);
				}
                else
                {
                    a.transform.Rotate(0, 3, 0);
                }
            }

        }
		if (Input.GetKey ("d") == true) {
			if (a.tag == "smallobject") {
				Destroy (a);
				Price = -500;
				Price2 = Price2 + Price;
				PriceText.text =GetComponent<Text>().text = Price2.ToString();
			} else if (a.tag == "middleobject") {
				Destroy (a);
				Price = -1000;
				Price2 = Price2 + Price;
				PriceText.text =GetComponent<Text>().text = Price2.ToString();
			} else if (a.tag == "bigobject") {
				Destroy (a);
				Price = -10000;
				Price2 = Price2 + Price;
				PriceText.text =GetComponent<Text>().text = Price2.ToString();
			} else if (a.tag == "wall") {
				Destroy (a);
				Price = -1000;
				Price2 = Price2 + Price;
				PriceText.text =GetComponent<Text>().text = Price2.ToString();

			
		}

		}
			

    }

    private void Wallanimation()
    {
        wallcontrol.SetTrigger("wallstart");
    }

    private void flooranimation()
    {
        floorcontrol.SetTrigger("floorstart");
    }
	public void decrease (){
		Price = -500;
		Price2 = Price2 + Price;
		Displayprice ();
	}

	public void decreasebig (){
		Price =-1000;
		Price2 = Price2 + Price;
		Displayprice ();
	}

	public void decreasest (){
		Price =-10000;
		Price2 = Price2 + Price;
		Displayprice ();
	}

	public void add()
	{
		Price = 500;
		Price2 = Price2 + Price;
		Displayprice();
	}
	public void addbig()
	{
		Price = 1000;
		Price2 = Price2 + Price;
		Displayprice ();
	}

	public void addbiggest()
	{
		Price = 10000;
		Price2 = Price2 + Price;
		Displayprice ();
	}

	public void Displayprice()
	{
		PriceText.text =GetComponent<Text>().text = Price2.ToString();

	}

    public void changecolor1()
    {
        if(a.tag == "wall")
        {
            a.GetComponent<Renderer>().material = color1;
        }      
    }

    public void changecolor2()
    {
        if(a.tag =="wall")
        {
            a.GetComponent<Renderer>().material = color2;
        }     
    }

    public void changecolor3()
    {
        if (a.tag == "wall")
        {
            a.GetComponent<Renderer>().material = color3;
        }
    }

    public void changecolor4()
    {
        if (a.tag == "wall")
        {
            a.GetComponent<Renderer>().material = color4;
        }
    }

    public void changecolor5()
    {
        if (a.tag == "wall")
        {
            a.GetComponent<Renderer>().material = color5;
        }
    }
}

