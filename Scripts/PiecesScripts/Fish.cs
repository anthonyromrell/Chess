using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Fish : Animal {
	
	public override void Eat()
	{
		Debug.Log("Eats with mouth, underwater");
		
		Debug.Log("Eats food whole");
	
	}

	public override void Move()
	{
		Debug.Log("We swim");
		//
		//
		//	
	}
}
