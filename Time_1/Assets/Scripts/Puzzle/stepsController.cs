using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsController : MonoBehaviour
{
    public GameObject [] stepsList = {null, null, null, null};
    private int _value = -1;
    public void KeepSteps (GameObject squareMap)
    {
        _value++;
        if(_value==4)
        {
            _value = 0;
        }
        stepsList[_value] = squareMap;
    }











}