using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringController : MonoBehaviour
{

	[SerializeField] private GameObject ring;
	[SerializeField] private PlayerInv playerInv;

	public void OnClick()
	{
		playerInv.HasRing = true;
		ring.SetActive(false);
	}

}
