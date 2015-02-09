using UnityEngine;
using System.Collections;

public class OutlineCharacter : MonoBehaviour
{
		private static Shader shaderNoOutline = Shader.Find ("Diffuse");
		private static Shader shaderOutline = Shader.Find ("Outlined/Diffuse");

		private void RenderVisibility ()
		{

		}

		void Start ()
		{
				Debug.Log ("Start");
		}

		void Update ()
		{
				if (renderer.IsVisibleFrom (GameObject.Find ("RightEyeAnchor").camera)) {
						renderer.material.shader = shaderOutline;
				} else {
						renderer.material.shader = shaderNoOutline;
				}

		}
}
