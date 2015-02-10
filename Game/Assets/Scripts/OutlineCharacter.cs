using System.Collections;
using UnityEngine;

public class OutlineCharacter : MonoBehaviour
{
		private static Shader shaderNoOutline = Shader.Find ("Diffuse");
		private static Shader shaderOutline = Shader.Find ("Outlined/Diffuse");
		private Camera camera;
	public float archerAngle;
	

		void Start ()
		{
				Debug.Log ("Start");
			foreach (Camera c in Camera.allCameras) {
						if (c.gameObject.name.Equals ("RightEyeAnchor")) {
								camera = c.gameObject.camera;
								break;
						}
				}
		}

		void Update ()
		{

		Vector3 cam = Vector3.Normalize (camera.transform.forward);
		//Debug.Log (camera.);
		Vector3 archer = Vector3.Normalize(this.gameObject.transform.position);
		float dotProduct = Vector3.Dot (cam, archer);
				if (renderer.IsVisibleFrom (camera) && dotProduct > 0 && dotProduct < 90){
						renderer.material.shader = shaderOutline;
				} else {
						renderer.material.shader = shaderNoOutline;
				}
		Debug.Log (Vector3.Dot (cam, archer));

		}
}
