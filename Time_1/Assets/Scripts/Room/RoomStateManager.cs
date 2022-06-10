using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomStateManager : MonoBehaviour
{
	[SerializeField] private GameObject[] rooms;

	private int current_room;

	private void Awake() {
		current_room = 0;
		foreach (var room in rooms ) {
			room.SetActive(false);
		}

		rooms[current_room].SetActive(true);
	}

	private void SetRoom(int room) {
		rooms[current_room].SetActive(false);
		current_room = room;
		rooms[current_room].SetActive(true);
	}

	public void GotoNextRoom()
    {
		SetRoom(current_room + 1);
    }
	public void GotoPreviousRoom()
    {
		SetRoom(current_room - 1);
    }
}

