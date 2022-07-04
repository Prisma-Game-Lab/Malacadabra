using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
	private bool hasPage = false;
	private bool hasPage2 = false;
	private bool hasRing = false;
	private bool hasScrewdriver = false;
	[SerializeField] private GameObject ringIndicator;
	[SerializeField] private GameObject pageIndicator;
	[SerializeField] private GameObject screwdriverIndicator;
	[SerializeField] private GameObject pageIndicator2;

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

			pageIndicator.SetActive(hasPage2);
		}
	}
	private void Awake() {
		screwdriverIndicator.SetActive(hasScrewdriver);
		ringIndicator.SetActive(hasRing);
		pageIndicator.SetActive(hasPage);
		pageIndicator2.SetActive(hasPage2);


}
}

