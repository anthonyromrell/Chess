using UnityEngine;

[CreateAssetMenu(fileName = "GameBoard")]
public class GameBoardBase : ScriptableObject
{

	private void PrintThis()
	{
		Debug.Log("Cool");
	}


	public Transform CurrentPiecePosition;
	public Transform PieceReposition;

	public void MovePiece()
	{
		CurrentPiecePosition.position = PieceReposition.position;
	}
}
