using System.Collections;
using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;
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
