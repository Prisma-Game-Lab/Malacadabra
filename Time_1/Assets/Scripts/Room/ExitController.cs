using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class ExitController : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI exit_text;
	[SerializeField] private PlayerInv playerInv;
	private bool isClosed = true;

	private void Awake() {
		exit_text.text = "EXIT\n" + (isClosed ? "(CLOSED)" : "(OPEN)");
	}

	public void TryEnter() {
		if (isClosed) {
			if (playerInv.HasKey) {
				isClosed = false;
				exit_text.text = "EXIT\n" + (isClosed ? "(CLOSED)" : "(OPEN)");
				playerInv.HasKey = false;
			}
		} else {
			SceneManager.LoadScene("VictoryScene");
		}
	}
}

