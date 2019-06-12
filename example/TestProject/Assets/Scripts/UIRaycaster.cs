using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRaycaster : MonoBehaviour
{
	[SerializeField] private Transform origin;
	[SerializeField] private LayerMask mask;

	private bool toggleActive;
	private GameObjectConcretePointerHandler cachedComponent;

	// Update is called once per frame
	void Update()
    {
		RaycastHit hit;
		if (Physics.Raycast(origin.position, origin.forward, out hit, Mathf.Infinity, mask))
		{
			cachedComponent = hit.transform.GetComponent<GameObjectConcretePointerHandler>();

			if(cachedComponent != null)
			{
				toggleActive = true;
				cachedComponent.Activate(true);
			}
		}
		else if(toggleActive)
		{
			toggleActive = false;
			cachedComponent.Activate(false);
		}
	}
}