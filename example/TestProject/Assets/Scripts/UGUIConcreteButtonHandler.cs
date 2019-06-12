using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UGUIConcreteButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	private string originalText;
	private bool isGazedAt;
	private Text label;

	private void Awake () {
		label = GetComponentInChildren<Text> ();
		originalText = label.text;
	}

	private void SetTextIfGazedAt(string text) {
		if (isGazedAt) {
			label.text = text;
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
