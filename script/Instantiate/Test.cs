using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	//這裏存放所有你想要顯示的面板
	public GameObject[] panels;
	//當前顯示面板的索引值  如果爲-1則是關閉所有面板
	public int current_Index;
	//是否切換了面板  如果你點擊了按鈕那就是要切換，沒有點擊就是不切換
	//默認值爲false
	public bool isChange = false;


	//這個函數就是這個代碼的核心控制 在updata中每幀執行
	public void Display()
	{
		//如果切換了才執行，沒有切換就不執行直接return就可以結束函數的運行
		if(!isChange)
		{
			return;
		}
		//切換完了就把它的值 = false  這樣你點擊按鈕只會觸發一次
		isChange = false;
		//首先關閉所有顯示的面板 這裏使用foreach循環遍歷所有的面板
		foreach(GameObject i in panels)
		{
			//關閉顯示
			i.SetActive(false);
		}
		//這裏處理current_Index爲-1的情況  爲-1就不在顯示面板了直接return結束；

		//打開當前面板
		panels[current_Index].SetActive(true);
	}

	//當按鈕點擊的時候調用這個方法就行了 
	public void SelectPanel(int index)
	{
		isChange = true;
		current_Index = index;
	}

	// Use this for initialization
	void Start () {
		if(current_Index == -1)
		{
			for (int x = 1; x<11; x++)
			{
				panels[x].SetActive(false);
			}
			return;
		}
	}

	// Update is called once per frame
	void Update () {
		Display();
	}



}