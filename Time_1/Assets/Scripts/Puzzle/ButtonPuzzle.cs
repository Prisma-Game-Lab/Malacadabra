using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    public GameObject gameManager;
    public bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrueonClick(){
	clicked = true;
	gameManager.GetComponent<OrderPuzzle>().checkOrder(gameObject);
}
}
