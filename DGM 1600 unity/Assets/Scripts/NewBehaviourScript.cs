using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	int myInt = 2000;
	
	void start()
	{
		
	}
	
	// Use this for initialization
	void update () 
	{
		myInt = DivideByTwo(myInt);
		Debug.Log (myInt);
	}
	
	int DivideByTwo (int number)
	{
		int ret;
		ret = number / 2;
		return ret;
	}
}