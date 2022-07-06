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
	[SerializeField] private int _pageTreshold = 7;
	[SerializeField] private bool _inplace = false;
	[SerializeField] private Vector2 initialTransform;


	public void OnBeginDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = false;
		initialTransform = _transform.anchoredPosition;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = true;

		if (Vector2.Distance(Camera.main.ScreenToWorldPoint(_transform.anchoredPosition), Camera.main.ScreenToWorldPoint(_transform2.anchoredPosition)) < _pageTreshold)
		{
			_inplace = true;
			_transform.anchoredPosition = _transform2.anchoredPosition;
			_puzzleManager.somaPag();
		}
        else
        {
			_transform.anchoredPosition = initialTransform;
        }
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_transform.anchoredPosition += eventData.delta;
		Debug.Log(Vector2.Distance(Camera.main.ScreenToWorldPoint(_transform.anchoredPosition), Camera.main.ScreenToWorldPoint(_transform2.anchoredPosition)));
		Debug.Log(eventData.delta);
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (_inplace) return;

	}
}

