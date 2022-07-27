using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPosition : MonoBehaviour
{   
    private GameObject hand = getClickedObject();
    private int Small = 3;
    private int Mid = 12;
    private int Big = 9;
    [serialiazedfield]
    private GameObject circle;
    public bool correctPosicion = false
    private void OnMouseDown ()
    {
        if(hand.tag == "ClockHandBig")
        {
            ClockHandBig.Rotate(Vector3.back, 2.5f);   
        }
        elseif(hand.tag == "ClockHandMid")
        {
            ClockHandMid.Rotate(Vector3.back, 2.5f);
        }
        else(hand.tag == "ClockHandSmall")
        {
            ClockHandSmall.Rotate(Vector3.back, 2.5f);
        }
        

    }
        
        private void CheckHands ()
    {
        if(ClockHandBig != Big) && (ClockHandMid != Mid) && (ClockHandSmall != Small)
        {
            correctPosicion = false

        }
    }
    correctPosicion = true

    
    public Update ()
    {
        if(CheckHands == true)
        {
            circle.SetActive(true);
        }
    circle.SetActive(false);
    }

    
}
