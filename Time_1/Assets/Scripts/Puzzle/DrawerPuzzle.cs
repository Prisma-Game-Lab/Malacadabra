using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawerPuzzle : MonoBehaviour
{

    public int [] ticketCode = {3, 5, 5, 4, 3, 4, 5, 3};
    public int [] ringCode = {3, 3, 3, 3, 3, 3, 3, 3};
    public int [] attemptCode = new int [8];
    private int currentIndex = 0;
    private int addedValue;
    private bool ticketCompleted = false;
    private bool ringCompleted = false;
    public GameObject ticket;
    public GameObject ring;

    public bool CheckTicketValues ()
    {
        for (int i = 0; i<ticketCode.Length; i++)
        {
            if (ticketCode[i] != attemptCode[i])
            {
                return false;
            }
            
        }
        ticketCompleted = true;
        TicketWin();
        return true;
    }

    public bool CheckRingValues ()
    {
        for (int i = 0; i<ringCode.Length; i++)
        {
            if (ringCode[i] != attemptCode[i])
            {
                return false;
            }
            
        }
        ringCompleted = true;
        RingWin();
        return true;
    }

    private void EnterValue()
    {
        if (currentIndex == 8)
        {
            for (int i = 0; i<attemptCode.Length - 1; i++)
            {
                attemptCode[i] = attemptCode[i+1];
            }
            attemptCode[7] = addedValue;
        }
        else
        {
            attemptCode[currentIndex] = addedValue;
            currentIndex = currentIndex + 1;
        }
    }

    private void TicketWin()
    {
        ticket.SetActive(true);
    }

    private void RingWin()
    {
        ring.SetActive(true);
    }
    
    void Update()
    {
        if (ticketCompleted == false || ringCompleted == false)
        {
            CheckTicketValues();
            CheckRingValues();
        }    
    }

    public void TriButton()
    {
        addedValue = 3;
        EnterValue();
    }

    public void SqaButton()
    {
        addedValue = 4;
        EnterValue();
    }

    public void PentButton()
    {
        addedValue = 5;
        EnterValue();    
    }
}