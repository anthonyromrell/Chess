using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GamePieceBase : ScriptableObject {

	public GameBoardBase GameBoard;
	public GameObject Art;
	public GameObject MovePattern;
	public GameSide GameSide;

	public abstract void StartMove();


}
