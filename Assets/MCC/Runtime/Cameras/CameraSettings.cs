﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace MCC.Cameras
{
	[CreateAssetMenu(fileName = "New Camera Settings", menuName = "MCC/Camera Settings", order = 0)]
	public class CameraSettings : ScriptableObject
	{
		public InputAction Look => lookAction.action;
		public float GetSensitivity(bool _controller) => _controller ? controllerSensitivity : mouseSensitivity;
		public float VerticalLookBounds => verticalLookBounds;
		
		[SerializeField, Range(0, 3)] private float mouseSensitivity = .5f;
		[SerializeField, Range(0, 3)] private float controllerSensitivity = .5f;
		[SerializeField, Range(0, 90)] private float verticalLookBounds = 90;

		[SerializeField] private InputActionReference lookAction;
	}
}