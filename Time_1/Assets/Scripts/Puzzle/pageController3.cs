using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageController3 : MonoBehaviour
{

	[SerializeField] private GameObject page3;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasPage3 = true;
		page3.SetActive(false);
	}

}
