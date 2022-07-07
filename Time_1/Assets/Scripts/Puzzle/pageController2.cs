using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageController2 : MonoBehaviour
{

	[SerializeField] private GameObject page2;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasPage2 = true;
		page2.SetActive(false);
	}

}
