using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
	[SerializeField] int[] code = {2, 1, 3};
	[SerializeField] GameObject[] buttons;
	[SerializeField] GameObject suitCaseOpen;
	[SerializeField] GameObject suitCaseClose;

	private int[] attempt;
	private int tries = 0;

	private void Awake() {
		attempt = new int[code.Length];
		Restart();
	}

	private void Restart() {
		foreach (var button in buttons)
			button.SetActive(true);
		suitCaseClose.SetActive(true);
		suitCaseOpen.SetActive(false);
		tries = 0;
	}

	private void Win() {
		foreach (var button in buttons)
			button.SetActive(false);
		suitCaseClose.SetActive(false);
		suitCaseOpen.SetActive(true);
	}

	private bool isCodeRight() {
		for (int i = 0; i < attempt.Length; ++i) {
			if (attempt[i] != code[i])
				return false;
		}

		return true;
	}

	public void Try(int code) {
		attempt[tries++] = code;
		buttons[code-1].SetActive(false);

		if (tries == attempt.Length) {
			if (isCodeRight())
				Win();
			else
				Restart();
		}
	}
}

