﻿using UnityEngine;

public static class RendererExtensions
{
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		if (camera != null) {
			Debug.Log (camera.camera);
						Plane[] planes = GeometryUtility.CalculateFrustumPlanes (camera);
						return GeometryUtility.TestPlanesAABB (planes, renderer.bounds);
		}
		return false;

	}
}