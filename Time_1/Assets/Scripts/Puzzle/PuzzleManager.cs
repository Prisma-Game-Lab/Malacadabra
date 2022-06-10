using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private int contPag = 0;

    [SerializeField] private GameObject ring;

    private void Start()
    {
        ring.SetActive(false);
        
    }

    public void somaPag()
    {
        contPag++;
        if (contPag >= 3)
        {
            ring.SetActive(true);
        }
    }
}
