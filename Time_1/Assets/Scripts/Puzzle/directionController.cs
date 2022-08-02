using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionController : MonoBehaviour
{
    public List<Direction> playerSteps;
    public GameObject sign;
    public Direction [] directionsList;
    public RectTransform map;
    public GameObject player;
    public int stepsCount;
    private float value;
    private Vector2 initialPosition;
    private RectTransform playerRectTransform;

    public void Start()
    {
        value = Mathf.Floor(map.rect.width / 13);
        playerRectTransform = player.GetComponent<RectTransform>();
        initialPosition = playerRectTransform.anchoredPosition;
    }

    public void CheckDirections ()
    {
        for(int i = 0; i<playerSteps.Count; i++)
        {
            if(playerSteps[i] != directionsList[i])
            {
                playerRectTransform.anchoredPosition = initialPosition;
                playerSteps.Clear();
                stepsCount = 0;
                return;
            }
        }
        sign.SetActive(true);
        return;
    }

    public void MovePlayer(Direction direction)
    {
        RectTransform transform = playerRectTransform;
        Debug.Log(transform);
        switch(direction)
        {
            case Direction.up:
                Debug.Log(transform);
                transform.anchoredPosition = new Vector2(transform.anchoredPosition.x, transform.anchoredPosition.y + value);
                break;
            case Direction.down:
                transform.anchoredPosition = new Vector2(transform.anchoredPosition.x, transform.anchoredPosition.y - value);
                break;
            case Direction.left:
                transform.anchoredPosition = new Vector2(transform.anchoredPosition.x - value, transform.anchoredPosition.y);
                break;
            default:
                transform.anchoredPosition = new Vector2(transform.anchoredPosition.x + value, transform.anchoredPosition.y);
                break;
        }
    }

    void Update()
    {
        if(stepsCount == directionsList.Length)
        {
            CheckDirections();
        }
    }
}
