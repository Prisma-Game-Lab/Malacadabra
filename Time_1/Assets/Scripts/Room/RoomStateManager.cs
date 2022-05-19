using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Rooms {
	START,
	PUZZLE,
}

public class RoomStateManager : MonoBehaviour
{
	[SerializeField] private GameObject[] rooms;

	private Rooms current_room = Rooms.START;

	private void Awake() {
		foreach (var room in rooms ) {
			room.SetActive(false);
		}

		rooms[(int)current_room].SetActive(true);
	}

	private void SetRoom(Rooms room) {
		rooms[(int)current_room].SetActive(false);
		current_room = room;
		rooms[(int)current_room].SetActive(true);
	}

	public void GotoStart() => SetRoom(Rooms.START);
	public void GotoPuzzle() => SetRoom(Rooms.PUZZLE);
}

