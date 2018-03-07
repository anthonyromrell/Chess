using UnityEngine;

public class Board : MonoBehaviour
{

	public Transform CurrentPiecePosition;
	public Transform PieceReposition;


	public void MovePiece()
	{
		CurrentPiecePosition.position = PieceReposition.position;
	}

}
