using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
	private bool hasPage = false;
	private bool hasPage2 = false;
	private bool hasPage3 = false;
	private bool hasRing = false;
	private bool hasScrewdriver = false;
	private bool hasKey = false;
	//private bool hasTicket = false;
	private bool hasCheese = false;
	private bool hasKnife = false;
	private bool hasDial = false;

	[SerializeField] private GameObject ringIndicator;
	[SerializeField] private GameObject screwdriverIndicator;
	[SerializeField] private GameObject pageIndicator;
	[SerializeField] private GameObject pageIndicator2;
	[SerializeField] private GameObject pageIndicator3;
	[SerializeField] private GameObject keyIndicator;
	//[SerializeField] private GameObject ticketIndicator;
	[SerializeField] private GameObject cheeseIndicator;
	[SerializeField] private GameObject knifeIndicator;
	[SerializeField] private GameObject dialIndicator;

	public bool HasScrewdriver
	{
		get => hasScrewdriver;
		set
		{
			hasScrewdriver = value;

			screwdriverIndicator.SetActive(hasScrewdriver);
		}
	}

	public bool HasRing
	{
		get => hasRing;
		set
		{
			hasRing = value;

			ringIndicator.SetActive(hasRing);
		}
	}
	public bool HasPage
	{
		get => hasPage;
		set
		{
			hasPage = value;

			pageIndicator.SetActive(hasPage);
		}
	}
	public bool HasPage2
	{
		get => hasPage2;
		set
		{
			hasPage2 = value;

			pageIndicator2.SetActive(hasPage2);
		}
	}
	public bool HasPage3
	{
		get => hasPage3;
		set
		{
			hasPage3 = value;

			pageIndicator3.SetActive(hasPage3);
		}
	}

	public bool HasKey
	{
		get => hasKey;
		set
		{
			hasKey = value;

			keyIndicator.SetActive(hasKey);
		}
	}

	/*public bool HasTicket
	{
		get => hasTicket;
		set
		{
			hasTicket = value;

			ticketIndicator.SetActive(hasTicket);
		}
	}*/

	public bool HasCheese
	{
		get => hasCheese;
		set
		{
			hasCheese = value;

			cheeseIndicator.SetActive(hasCheese);
		}
	}

	public bool HasKnife
	{
		get => hasKnife;
		set
		{
			hasKnife = value;

			knifeIndicator.SetActive(hasKnife);
		}
	}

	public bool HasDial
	{
		get => hasDial;
		set
		{
			hasDial = value;

			dialIndicator.SetActive(hasDial);
		}
	}

	private void Awake() {
		screwdriverIndicator.SetActive(hasScrewdriver);
		ringIndicator.SetActive(hasRing);
		pageIndicator.SetActive(hasPage);
		pageIndicator2.SetActive(hasPage2);
		pageIndicator3.SetActive(hasPage3);
		keyIndicator.SetActive(hasKey);
		//ticketIndicator.SetActive(hasTicket);
		cheeseIndicator.SetActive(hasCheese);
		knifeIndicator.SetActive(hasKnife);
		dialIndicator.SetActive(hasDial);

	}
}

