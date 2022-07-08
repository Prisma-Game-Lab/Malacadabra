using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrewdriverDragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[SerializeField] private RectTransform _transform;
	[SerializeField] private GameObject _target;
	private RectTransform _transform2;
	[SerializeField] private GameObject _appear;
	[SerializeField] private CanvasGroup _canvasGroup;
	[SerializeField] private float _pageTreshold = 7;
	[SerializeField] private bool _inplace = false;
	[SerializeField] private Vector2 initialTransform;
	[SerializeField] private Canvas canvas;
	private Camera cam;

	private float UIDistance(RectTransform rt, RectTransform rt2)
	{
		var p1 = Camera.main.WorldToScreenPoint(rt.TransformPoint(Vector2.zero));
		var p2 = Camera.main.WorldToScreenPoint(rt2.TransformPoint(Vector2.zero));
		return Vector2.Distance(p1, p2) / 10;
	}

	public void Awake()
	{
		_transform2 = _target.GetComponent<RectTransform>();
		var bounds = _transform2.rect;
		_pageTreshold = (bounds.width + bounds.height) / 4;
		cam = Camera.main;

	}

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
		if (UIDistance(_transform, _transform2) < _pageTreshold)
		{
			_inplace = true;
			_transform.anchoredPosition = _transform2.anchoredPosition;
			_target.SetActive(false);
			_appear.SetActive(true);

			//gustavo: coloquei isso pq o objeto estava indo pro lugar errado e deveria sumir
			gameObject.SetActive(false);
		}
		else
		{
			_transform.anchoredPosition = initialTransform;
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_transform.anchoredPosition += eventData.delta / canvas.scaleFactor;
		//Debug.Log(Vector2.Distance(_transform.anchoredPosition, _transform2.anchoredPosition));
		//Debug.Log(eventData.delta);
		Debug.Log(UIDistance(_transform, _transform2));
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (_inplace) return;

	}
}
