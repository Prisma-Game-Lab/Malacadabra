using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionController : MonoBehaviour
{
    public List<GameObject> direction;
    public GameObject SetActive;
    [HideInInspector]
    public GameObject [] stepsList;
    private bool correct = false;
    public void Start()
    {
        stepsList = GetComponent<stepsController>().stepsList;

    }
    public bool checkDirections ()
    {
        for(int i = 0; i<direction.Count; i++)
        {
            if(stepsList[i].GetComponent<stepsController>()!=direction[i])
            {
                return false;

            }
    
        }
        correct = true;
        return true;
    }
    private void showSign()
    {
        if(correct == true)
        {
            
        }

    }

    void Update()
    {
        if (correct == false)
        {
            checkDirections();
        }
        else
        {
           showSign();
        } 
    }
}
