using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSymbol : MonoBehaviour
{
  public int value = 0;
  public List<Sprite> symbolList;   
  public Image symbol;
  
  public void IncreaseNumber(){
    value++;
    if (value > symbolList.Count - 1){
        value = 0;
    }
    symbol.sprite = symbolList[value];

  }
  public void DecreaseNumber(){
    value--;
    if (value < 0){
        value = symbolList.Count - 1;
    }
    symbol.sprite = symbolList[value];


  }
}
