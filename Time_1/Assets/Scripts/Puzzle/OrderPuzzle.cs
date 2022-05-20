using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderPuzzle : MonoBehaviour
{

    public Button[] buttons;
    public void checkOrder(GameObject obj) {
    switch(obj.tag){
        case "2":
            break;
        case "1":
            if(!buttons[0].GetComponent<ButtonPuzzle>().clicked)
            {
                foreach(Button button in buttons)
                {
                    button.GetComponent<ButtonPuzzle>().clicked = false;
                }
            }
        break;
        case "3":
            if(!buttons[0].GetComponent<ButtonPuzzle>().clicked || buttons[1].GetComponent<ButtonPuzzle>().clicked)
            {
                foreach(Button button in buttons)
                {
                    button.GetComponent<ButtonPuzzle>().clicked = false;
                }
            }
        break;
        }   
   }

}
