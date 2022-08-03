using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    public FinalButtonPuzzle finalButtonPuzzle;

    public void OnClick(int buttonvalue)
    {
        finalButtonPuzzle.addedButtonValue = buttonvalue;
        finalButtonPuzzle.EnterButtonValue();
        finalButtonPuzzle.CheckCode();
    }

}
