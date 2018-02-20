﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPiece : MonoBehaviour
{

	public GamePieceBase GamePiece;

	public GameObject Pattern;

	private void OnMouseDown()
	{
		//GamePiece.StartMove();
		Pattern.SetActive(true);
		GamePiece.GameBoard.CurrentPiecePosition = transform;
		print(GamePiece.GameBoard.CurrentPiecePosition);
	}
}
