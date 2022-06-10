using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuitController : MonoBehaviour
{
	[SerializeField] private PlayerInv playerInv;

	public void TryEnter()
	{
		if (playerInv.HasRing) {
			SceneManager.LoadScene("VictoryScene");
		}
	}
}
