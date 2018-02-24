using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalWork : MonoBehaviour
{

	public Animal ThisAnimal;
	

	void Awake ()
	{
		FunctionsAndEvents.DelagateEvent += RunFunction;
	}

	public void RunFunction()
	{
		print(ThisAnimal.Speed);
		print(ThisAnimal.Health);
		ThisAnimal.Eat();
		ThisAnimal.Move();
	}
	
}
