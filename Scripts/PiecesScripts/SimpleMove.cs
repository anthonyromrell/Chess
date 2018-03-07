using UnityEngine;

public class SimpleMove : MonoBehaviour
{

	public Transform Piece;
	
	private void OnMouseDown()
	{
		Piece.position = transform.position;
	}
}
