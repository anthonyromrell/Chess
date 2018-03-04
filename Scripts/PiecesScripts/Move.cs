using System.Collections;
using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;

public class Move : MonoBehaviour
{

	public GameEventSingle Event;
	public Piece Piece;

	public ClickEvent[] ClickEvents;

	void Awake()
	{
		Piece = ScriptableObject.CreateInstance<Piece>();
		Event = ScriptableObject.CreateInstance<GameEventSingle>();
		ClickEvents = GetComponentsInChildren<ClickEvent>();
		foreach (ClickEvent clickEvent in ClickEvents)
		{
			clickEvent.Event = Event;
			clickEvent.Piece = Piece;
			clickEvent.enabled = true;
		}

		var listener = GetComponent<GameEventListener>();
		listener.Event = Event;
		listener.enabled = true;
	}

	public void MoveThis()
	{
		transform.position = Piece.Location;
	}
}