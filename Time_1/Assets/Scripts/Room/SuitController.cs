using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuitController : MonoBehaviour
{
	[SerializeField] private PlayerInv playerInv;
	private bool isClosed = true;

	public void TryEnter()
	{
		if (isClosed)
		{
			if (playerInv.HasRing)
			{
				isClosed = false;
				
				playerInv.HasRing = false;
			}
		}
		else
		{
			SceneManager.LoadScene("VictoryScene");
		}
	}
}
