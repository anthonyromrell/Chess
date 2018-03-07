using UnityEngine;

public class MoveToBox : MonoBehaviour
{

	public GameBoardBase GameBoard;
	
	private void OnMouseUp()
	{
		GameBoard.PieceReposition = transform;
		GameBoard.MovePiece();
	}
}
