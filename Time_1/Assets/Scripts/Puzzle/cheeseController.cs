using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseController : MonoBehaviour
{

	[SerializeField] private GameObject cheese;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasCheese = true;
		cheese.SetActive(false);
	}

}
