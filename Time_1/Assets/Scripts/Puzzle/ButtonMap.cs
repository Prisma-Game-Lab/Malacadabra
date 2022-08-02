using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    up,
    down,
    left,
    right
};

public class ButtonMap : MonoBehaviour
{   
    //public stepsController stepsControllerObject;
    public Direction direction;
    public DirectionController directionController;

    public void SetDirection()
    {
        directionController.stepsCount++;
        directionController.playerSteps.Add(direction);
        directionController.MovePlayer(direction);
    }
    void Update()
    {

    }
}