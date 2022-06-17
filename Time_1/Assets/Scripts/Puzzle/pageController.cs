using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageController : MonoBehaviour
{

	[SerializeField] private GameObject page;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasPage = true;
		page.SetActive(false);
	}

}
