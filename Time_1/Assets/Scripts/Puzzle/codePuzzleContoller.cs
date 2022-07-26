using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codePuzzleContoller : MonoBehaviour
{   

    public int [] code = {1, 2, 3, 4};
    public GameObject zoomSuitCaseOpen;
    public GameObject zoomSuitCaseClose;
    public GameObject suitCaseOpen;
    public GameObject suitCaseClosed;
    public GameObject [] displays;
    private bool completed = false;

    public bool checkValues ()
    {
        for (int i = 0; i<code.Length; i++)
        {
            if (displays[i].GetComponent<ButtonValue>().value != code[i])
            {
                return false;
            }
            
        }
        completed = true;
        Win();

        //Toca com da mala abrindo
        FindObjectOfType<AudioManager>().Play("CaseOpen");
        
        return true;
    }

    private void Win()
    {
        zoomSuitCaseClose.SetActive(false);
        zoomSuitCaseOpen.SetActive(true);
        suitCaseOpen.SetActive(true);
        suitCaseClosed.SetActive(false);

    }
    
    void Update()
    {
        if (completed == false)
        {
            checkValues();
        }    
    }
}
  
