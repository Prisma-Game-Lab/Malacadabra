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


	public void OnBeginDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = false;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = true;

		if (Vector2.Distance(_transform.anchoredPosition, _transform2.anchoredPosition) < _pageTreshold)
		{
			_inplace = true;
			_transform.anchoredPosition = _transform2.anchoredPosition;
			Debug.Log("Soltou");
			_puzzleManager.somaPag();
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_transform.anchoredPosition += eventData.delta;

	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (_inplace) return;
		Debug.Log("Apertou");

	}
}

