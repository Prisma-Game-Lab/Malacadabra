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
    private bool completed = false;
         
    private bool CheckHands()
    {
        if((Mathf.Abs(ClockHandBig.transform.rotation.eulerAngles.z - (360 - Big)) < error ) 
        && (Mathf.Abs(ClockHandMid.transform.rotation.eulerAngles.z - (360 - Mid)) < error ) 
        && (Mathf.Abs(ClockHandSmall.transform.rotation.eulerAngles.z - (360 - Small)) < error ))
        {
            return true;
        }
    return false;
    }
    
    void Update ()
    {
        CheckHands();
        //Debug.Log((ClockHandBig.transform.rotation.eulerAngles.z - (360 - Big)));
        //Debug.Log("Angulo Euler" + ClockHandBig.transform.rotation.eulerAngles.z);
        if(CheckHands() && !completed)
        {
            circle.SetActive(true);
            FindObjectOfType<AudioManager>().Play("OpenClock");
            completed = true;
            
        }
    }    
}

