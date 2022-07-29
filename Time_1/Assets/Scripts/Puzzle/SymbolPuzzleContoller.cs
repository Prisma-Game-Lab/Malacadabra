using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolPuzzleContoller : MonoBehaviour
{   

    public int [] code;
    public GameObject puzzleDisplay;
    public GameObject hexScreen;
    public GameObject [] displays;
    private bool completed = false;

    public bool checkValues ()
    {
        for (int i = 0; i<code.Length; i++)
        {
            if (displays[i].GetComponent<ButtonSymbol>().value != code[i])
            {
                return false;
            }
            
        }
        completed = true;
        Win();
        
        return true;
    }

    private void Win()
    {
        puzzleDisplay.SetActive(false);
        hexScreen.SetActive(true);
    }
    
    void Update()
    {
        if (completed == false)
        {
            checkValues();
        }    
    }
}
  
