using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonValue : MonoBehaviour
{

  public int value = 0;  
  public TMP_Text text;
  void Start(){
    text.text = value.ToString();

  }
  public void IncreaseNumber(){
    value++;
    if (value>9){
        value = 0;
    }
    text.text = value.ToString();

  }
  public void DecreaseNumber(){
    value--;
    if (value<0){
        value = 9;
    }
    text.text = value.ToString();

  }

  
}
