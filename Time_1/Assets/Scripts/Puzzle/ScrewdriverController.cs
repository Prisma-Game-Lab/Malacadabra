using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewdriverController : MonoBehaviour
{
	[SerializeField] private GameObject screwdriver;
	[SerializeField] private PlayerInv playerInv;

	public void OnClick()
	{
		playerInv.HasScrewdriver = true;
		screwdriver.SetActive(false);
	}
}

