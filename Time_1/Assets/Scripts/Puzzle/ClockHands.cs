using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHands : MonoBehaviour
{   
    private GameObject hand;
    public float Small;
    public float Mid;
    public float Big;
    public float error;
    public GameObject ClockHandBig;
    public GameObject ClockHandMid;
    public GameObject ClockHandSmall;
    public GameObject circle;
    
    private void getClickedObject()
    {
        if(hand.tag == "ClockHandBig")
        {
            ClockHandBig.transform.Rotate(Vector3.back);   
        }
        else if(hand.tag == "ClockHandMid")
        {
            ClockHandMid.transform.Rotate(Vector3.back);
        }
        else
        {
            ClockHandSmall.transform.Rotate(Vector3.back);
        }
        

    }
        
    private bool CheckHands ()
    {
        if(( Mathf.Abs(ClockHandBig.transform.rotation.eulerAngles.z - Big) < error ) 
        && (Mathf.Abs(ClockHandMid.transform.rotation.eulerAngles.z - Mid) < error ) 
        && (Mathf.Abs(ClockHandSmall.transform.rotation.eulerAngles.z - Small) < error ))
        {
            
            return true;

        }
    return false;
    }
    

    
    void Update ()
    {
        if(CheckHands() == true)
        {
            circle.SetActive(true);
            
        }
    else
    {
        CheckHands();
    }
    }

    
}

