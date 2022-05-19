using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
	private bool hasKey = false;
	[SerializeField] private GameObject keyIndicator;

	public bool HasKey {
		get => hasKey;
		set {
			hasKey = value;

			keyIndicator.SetActive(hasKey);
		}
	}


	private void Awake() {
		keyIndicator.SetActive(hasKey);
	}

}

