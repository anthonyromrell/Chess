using UnityEngine;

public class ClickEvent : MonoBehaviour
{

	public GameEventSingle Event;
	public Piece Piece;

	private void OnMouseUp()
	{
		Piece.Location = transform.position;
		Event.Raise();
	}
}
