using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[SerializeField] private RectTransform _transform;
	[SerializeField] private GameObject _target;
	[SerializeField] private GameObject _appear;
	private RectTransform _transform2;
	[SerializeField] private CanvasGroup _canvasGroup;
	[SerializeField] private PuzzleManager _puzzleManager;
	private float _pageTreshold;
	[SerializeField] private bool _inplace = false;
	[SerializeField] private Vector2 initialTransform;
	[SerializeField] private Canvas canvas;
	[SerializeField] private GraphicRaycaster m_Raycaster;
    private PointerEventData m_PointerEventData;
    [SerializeField] EventSystem m_EventSystem;
    //[SerializeField] RectTransform canvasRect;
	private Camera cam;

	private float UIDistance(RectTransform rt, RectTransform rt2)
    {
		var p1 = Camera.main.WorldToScreenPoint(rt.TransformPoint(Vector2.zero));
		var p2 = Camera.main.WorldToScreenPoint(rt2.TransformPoint(Vector2.zero));
		return Vector2.Distance(p1, p2)/10;
	}

    public void Awake()
    {
		_transform2 = _target.GetComponent<RectTransform>();
		var bounds = _transform2.rect;
		_pageTreshold = (bounds.width + bounds.height) / 40000 * Screen.height * 30;
		Debug.Log(_pageTreshold);
		cam = Camera.main;

	}

    public void OnBeginDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = false;
		initialTransform = _transform.anchoredPosition;
		FindObjectOfType<AudioManager>().Play("ItemDrag");
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_canvasGroup.blocksRaycasts = true;
		m_PointerEventData = new PointerEventData(m_EventSystem);
        m_PointerEventData.position = Input.mousePosition;
        
        List<RaycastResult> results = new List<RaycastResult>();

        m_Raycaster.Raycast(m_PointerEventData, results);

        DragAndDropSlot slot = null;
        foreach (var result in results)
        { 
            slot = result.gameObject.GetComponent<DragAndDropSlot>()? result.gameObject.GetComponent<DragAndDropSlot>() : slot;
        }
		if (slot && slot.gameObject == _target)
		{
			ExecuteDrop(slot.type);
		}
        else
        {
			_transform.anchoredPosition = initialTransform;
        }
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (_inplace) return;
		_transform.anchoredPosition += eventData.delta/canvas.scaleFactor;
		//Debug.Log(Vector2.Distance(_transform.anchoredPosition, _transform2.anchoredPosition));
		//Debug.Log(eventData.delta);
		//Debug.Log(UIDistance(_transform,_transform2));

	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (_inplace) return;

	}

	private void SetTargetOpacity(Image img, float opacity)
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, opacity);
    }

	    private void ExecuteDrop(SlotType slotType)
    {
        switch (slotType)
        {
            case SlotType.pagina:
                _inplace = true;
                _puzzleManager.somaPag();
                SetTargetOpacity(_target.GetComponent<Image>(), 1);

                //gustavo: coloquei isso pq o objeto estava indo pro lugar errado e deveria sumir
                gameObject.SetActive(false);

                FindObjectOfType<AudioManager>().Play("PlacePage");
                break;
			case SlotType.buraco:
                _inplace = true;
                //_target.SetActive(false);
                _appear.SetActive(true);
				//gustavo: o ideal e que ele n suma, mas vai isso msm
                gameObject.SetActive(false);
				break;
            case SlotType.geral:
                _inplace = true;
                _target.SetActive(false);
                _appear.SetActive(true);

                //gustavo: coloquei isso pq o objeto estava indo pro lugar errado e deveria sumir
                gameObject.SetActive(false);
                break;
        }
    }
}

