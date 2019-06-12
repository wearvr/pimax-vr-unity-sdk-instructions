using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(MeshRenderer))]
public class GameObjectConcreteButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	private Color originalColor;
	private bool isGazedAt;
	private MeshRenderer meshRenderer;

	private void Awake() {
		meshRenderer = GetComponent<MeshRenderer> ();
		originalColor = meshRenderer.material.color;
	}

	private void SetColorIfGazedAt(Color color) {
		if (isGazedAt) {
			meshRenderer.material.color = color;
		}
	}

	/* Pointer Events */

	public void OnPointerEnter(PointerEventData eventData) {
		isGazedAt = true;
	}

	public void OnPointerExit(PointerEventData eventData) {
		isGazedAt = false;
	}
}
