using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeController : MonoBehaviour
{

	[SerializeField] private GameObject knife;
	[SerializeField] private PlayerInv playerInv;

	public void OnClick()
	{
		playerInv.HasKnife = true;
		knife.SetActive(false);
	}

}
