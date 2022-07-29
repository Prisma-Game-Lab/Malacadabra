using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ticketController : MonoBehaviour
{

	[SerializeField] private GameObject ticket;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasTicket = true;
		ticket.SetActive(false);
	}

}
