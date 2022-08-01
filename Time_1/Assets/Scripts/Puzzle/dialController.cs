using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialController : MonoBehaviour
{

	[SerializeField] private GameObject dial;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasDial = true;
		dial.SetActive(false);
	}

}
