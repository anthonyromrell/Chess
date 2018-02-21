using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPiece : MonoBehaviour
{

	public GameBoardBase GameBoard;
	public GameObject Pattern;

	private void OnMouseDown()
	{
		//Pattern.SetActive(true);
		GameBoard.CurrentPiecePosition = transform;
	}
}
