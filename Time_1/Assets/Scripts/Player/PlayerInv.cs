using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
	private bool hasKey = false;
	private bool hasRing = false;
	[SerializeField] private GameObject keyIndicator;
	[SerializeField] private GameObject ringIndicator;


	public bool HasKey {
		get => hasKey;
		set {
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

			ringIndicator.SetActive(hasKey);
		}
	}
	private void Awake() {
		keyIndicator.SetActive(hasKey);
		ringIndicator.SetActive(hasKey);

	}

}

