using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
	private bool hasPage = false;
	private bool hasKey = false;
	private bool hasRing = false;
	[SerializeField] private GameObject keyIndicator;
	[SerializeField] private GameObject ringIndicator;
	[SerializeField] private GameObject pageIndicator;

	public bool HasKey
	{
		get => hasKey;
		set
		{
			hasKey = value;

			keyIndicator.SetActive(hasKey);
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
	private void Awake() {
		keyIndicator.SetActive(hasRing);
		ringIndicator.SetActive(hasRing);
		pageIndicator.SetActive(hasPage);

	}
}

