using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{

	public Transform Piece;
	
	private void OnMouseDown()
	{
		Piece.position = transform.position;
	}
}
