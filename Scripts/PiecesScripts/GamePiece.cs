using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Knight")]
public class GamePiece : GamePieceBase {

	//Activate a Pattern
	public GameBoardBase GameBoard;

	public override void StartMove()
	{
		MovePattern.SetActive(true);
	}

}