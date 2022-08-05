using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButtonPuzzle : MonoBehaviour
{
    public int[] finalCode = {1, 2, 3, 4, 5, 6};
    public int[] playerInput = new int [6];
    [HideInInspector]
    public int addedButtonValue;
    public GameObject openCase;
    public GameObject finalCase;
    private int codeIndex = 0;
    
    public bool CheckCode()
    {
        for (int i = 0; i<finalCode.Length; i++)
        {
            if (finalCode[i] != playerInput[i])
            {
                return false;
            }
        }
        Win();
        return true;
    }

    public void EnterButtonValue()
    {
        if(codeIndex == finalCode.Length)
        {
            for (int i = 0; i<playerInput.Length - 1; i++)
                {
                    playerInput[i] = playerInput[i+1];
                }
            playerInput[finalCode.Length - 1] = addedButtonValue;
        }
        else
        {
            playerInput[codeIndex] = addedButtonValue;
            codeIndex++;
        }
    }

    private void Win()
    {
        openCase.SetActive(false);
        finalCase.SetActive(true);
        FindObjectOfType<AudioManager>().Stop("BGM");
    }
}
