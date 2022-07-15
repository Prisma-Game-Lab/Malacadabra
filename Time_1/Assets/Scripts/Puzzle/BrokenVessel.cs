using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenVessel : MonoBehaviour
{
    public int requiredAttemps;
    public GameObject vessel;
    public GameObject brokenVessel;
    private int attemps;
    private bool completed = false;

    private void CheckCount()
    {
        if (attemps == requiredAttemps)
        {
            completed = true;
        }
    }
    
    public void AddCounter()
    {
        attemps++;
    }

    private void Win()
    {
        if(completed == true)
        {
            vessel.SetActive(false);
            brokenVessel.SetActive(true);
        }

    }

        void Update()
    {
        if (completed == false)
        {
            CheckCount();
        }
        else
        {
            Win();
        }
    }
}
