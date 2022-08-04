using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionController : MonoBehaviour
{
    [HideInInspector]
    public List<Direction> playerSteps;
    public GameObject sign;
    public Direction[] directionsList;
    public RectTransform map;
    public GameObject player;
    private GameObject[] directionButtons;
    [HideInInspector]
    public int stepsCount;
    private float value;
    private Vector2 initialPosition;
    private RectTransform playerRectTransform;

    public void Start()
    {
        value = Mathf.Floor(map.rect.width / 13);
        playerRectTransform = player.GetComponent<RectTransform>();
        initialPosition = playerRectTransform.anchoredPosition;
        directionButtons = new GameObject[4];
        directionButtons[0] = player.transform.GetChild(0).gameObject;
        directionButtons[1] = player.transform.GetChild(1).gameObject;
        directionButtons[2] = player.transform.GetChild(2).gameObject;
        directionButtons[3] = player.transform.GetChild(3).gameObject;
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
                CheckBorder();
                return;
            }
        }
        ChangeButtonState(false);
        sign.SetActive(true);
        return;
    }

    public void CheckBorder()
    {
        ChangeButtonState(true);

        if(playerRectTransform.anchoredPosition.y >= initialPosition.y + value * 3)
        {
            directionButtons[0].SetActive(false);
        }
        if(playerRectTransform.anchoredPosition.y <= initialPosition.y - value * 3)
        {
            directionButtons[1].SetActive(false);
        }
        if(playerRectTransform.anchoredPosition.x <= initialPosition.x - value * 6)
        {
            directionButtons[2].SetActive(false);
        }
        if(playerRectTransform.anchoredPosition.x >= initialPosition.x + value * 6)
        {
            directionButtons[3].SetActive(false);
        }
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
        CheckBorder();
    }

    void Update()
    {
        if(stepsCount == directionsList.Length)
        {
            CheckDirections();
        }
    }

    private void ChangeButtonState(bool state)
    {
        directionButtons[0].SetActive(state);
        directionButtons[1].SetActive(state);
        directionButtons[2].SetActive(state);
        directionButtons[3].SetActive(state);
    }
}
