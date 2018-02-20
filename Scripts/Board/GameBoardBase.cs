using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameBoard")]
public class GameBoardBase : ScriptableObject {

	//Detect Piece Interactions
	//Piece Location
	//Holds Pieces
	public Transform CurrentPiecePosition;
	public Transform PieceReposition;

	public void MovePiece()
	{
		CurrentPiecePosition.position = PieceReposition.position;
	}
}
