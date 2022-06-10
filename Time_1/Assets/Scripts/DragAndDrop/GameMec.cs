using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameMec : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private RectTransform _transform;
    [SerializeField] private RectTransform _transform2;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private PuzzleManager _puzzleManager;
	[SerializeField] private int pageTreshold = 5;


    public void OnBeginDrag(PointerEventData eventData)
    {

        _canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _canvasGroup.blocksRaycasts = true;

        if (Vector2.Distance(_transform.anchoredPosition, _transform2.anchoredPosition) < pageTreshold)
        {
			_transform.anchoredPosition = _transform2.anchoredPosition;
            Debug.Log("Soltou");
            _puzzleManager.somaPag();
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        _transform.anchoredPosition += eventData.delta;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Apertou");

    }
}
