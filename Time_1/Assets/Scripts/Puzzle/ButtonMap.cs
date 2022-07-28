using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMap : MonoBehaviour

{   
    public stepsController stepsControllerObject;
    public void OnClick()
    {
        stepsControllerObject.KeepSteps(this.gameObject);

    }
}