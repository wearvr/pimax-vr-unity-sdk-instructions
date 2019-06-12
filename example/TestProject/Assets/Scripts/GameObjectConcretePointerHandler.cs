using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(MeshRenderer))]
public class GameObjectConcretePointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
	private Color originalColor;
	private MeshRenderer meshRenderer;

	private bool active;

	private void Awake() {
		active = false;
		meshRenderer = GetComponent<MeshRenderer> ();
		originalColor = meshRenderer.material.color;
	}

	private void Update()
	{
		if(active)
		{
			meshRenderer.material.color = Color.green;
		}
		else
		{
			meshRenderer.material.color = originalColor;
		}
	}

	public void Activate(bool activate)
	{
		active = activate;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		active = true;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		active = false;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		meshRenderer.material.color = Color.red;
	}
}
