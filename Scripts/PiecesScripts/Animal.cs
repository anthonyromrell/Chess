using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : ScriptableObject
{

	public float Health = 100;
	public float Speed = 1.0f;

	public abstract void Eat();
	public abstract void Move();

}
