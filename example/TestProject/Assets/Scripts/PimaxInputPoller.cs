using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PVR.Unity;

public class PimaxInputPoller : MonoBehaviour, PVR.Unity.IPVRInputEventTarget
{
	private const float MIN_SWIPE_DELTA = 0.05f;
	private const float INDICATOR_COOLDOWN = 2.0f;

	[System.Serializable]
	private class IndicatorObject
	{
		public Color originalColor;
		public MeshRenderer renderer;
	}

	private class TouchpadInfo
	{
		public Vector2 firstPoint;
		public Vector2 lastPoint;
		public bool active;
		public Vector2 swipeNormal;

		public void SetActive(bool on, Vector2 position)
		{
			if (active != on)
			{
				if (on)
				{
					firstPoint = position;
					EndSwipeDirection();
				}
				else
				{
					lastPoint = position;
					CreateSwipeDirection();
				}
			}

			active = on;
		}

		private void CreateSwipeDirection()
		{
			var swipeDelta = (firstPoint - lastPoint);

			if (swipeDelta.magnitude >= MIN_SWIPE_DELTA)
			{
				//Normalise, and half scale into -1 to 1
				swipeNormal = (swipeDelta.normalized * 2) - Vector2.one;
			}
			else
			{
				swipeNormal = Vector2.zero;
			}
		}

		public void EndSwipeDirection()
		{
			swipeNormal = Vector2.zero;
		}
	}

	[SerializeField] private IndicatorObject swipeIndicator;
	[SerializeField] private IndicatorObject triggerIndicator;

	private void Awake()
	{
		swipeIndicator.originalColor = swipeIndicator.renderer.material.color;
		triggerIndicator.originalColor = triggerIndicator.renderer.material.color;

		for (var index = 0; index < touchpadInfo.Length; index++)
		{
			touchpadInfo[index] = new TouchpadInfo();
		}

		for (var index = 0; index < touchpadPositionCache.Length; index++)
		{
			touchpadPositionCache[index] = Vector2.zero;
		}
	}

	private void Update()
	{
		UpdateSwipeDetection();
	}

	//PVR Input events ------------------------------------------------------------

	public void OnAxisChange(PVRAxisEventData data)
	{
		touchpadPositionCache[data.hand] = new Vector2(data.x, data.y);
	}

	public void OnButtonPress(PVRButtonEventData data)
	{
		if (data.btn == PVR.pvrButton.pvrButton_Trigger)
		{
			Activate(triggerIndicator);
		}
		else if (data.btn == PVR.pvrButton.pvrButton_TouchPad)
		{
			touchpadInfo[data.hand].SetActive(true, touchpadPositionCache[data.hand]);
		}
	}

	public void OnButtonRelease(PVRButtonEventData data)
	{
		if (data.btn == PVR.pvrButton.pvrButton_Trigger)
		{
			DeActivate(triggerIndicator);
		}
		else if (data.btn == PVR.pvrButton.pvrButton_TouchPad)
		{
			touchpadInfo[data.hand].SetActive(false, touchpadPositionCache[data.hand]);
		}
	}

	public void OnButtonTouch(PVRButtonEventData data)
	{

	}

	public void OnButtonUntouch(PVRButtonEventData data)
	{

	}

	// Swipe calculation ----------------------------------------------------------

	private TouchpadInfo[] touchpadInfo = new TouchpadInfo[2];
	private Vector2[] touchpadPositionCache = new Vector2[2];
	private float swipeIndicatorCooldown;

	private void UpdateSwipeDetection()
	{
		swipeIndicatorCooldown += Time.deltaTime;

		foreach (var touchpad in touchpadInfo)
		{
			if(touchpad.swipeNormal != null && touchpad.swipeNormal != Vector2.zero)
			{
				//if normalized swipe is more 'up' than any other direction, color the indicator appropriatly.
				if(touchpad.swipeNormal.y > 0.1f)
				{
					Activate(swipeIndicator);
				}
				else
				{
					ActiveFalse(swipeIndicator);
				}

				//No longer need swipe information for this tuchpad
				touchpad.EndSwipeDirection();
				//Reset cooldown timer;
				swipeIndicatorCooldown = 0.0f;
			}
		}

		if(swipeIndicatorCooldown > INDICATOR_COOLDOWN)
		{
			DeActivate(swipeIndicator);
		}
	}

	//-----------------------------------------------------------------------------

	private void Activate(IndicatorObject targetRenderer)
	{
		targetRenderer.renderer.material.color = Color.green;
	}

	private void ActiveFalse(IndicatorObject targetRenderer)
	{
		targetRenderer.renderer.material.color = Color.red;
	}

	private void DeActivate(IndicatorObject targetRenderer)
	{
		targetRenderer.renderer.material.color = targetRenderer.originalColor;
	}
}
