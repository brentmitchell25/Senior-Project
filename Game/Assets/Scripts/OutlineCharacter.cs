using System.Collections;
using UnityEngine;

public class OutlineCharacter : MonoBehaviour
{
		private static Shader shaderNoOutline;
		private static Shader shaderOutline;
		private Camera camera;
		public float angle;

		void Start ()
		{
		shaderNoOutline = Shader.Find ("Diffuse");
		shaderOutline = Shader.Find ("Outlined/Diffuse");
				foreach (Camera c in Camera.allCameras) {
						if (c.gameObject.name.Equals ("RightEyeAnchor")) {
								camera = c.gameObject.GetComponent<Camera>();
								break;
						}
				}
		}

		void Update ()
		{
		if(Input.GetKeyDown("enter") || Input.GetKeyDown("return")) {
			Debug.Log("Enter pressed");
		   Application.LoadLevel("Forest");
		}
				Vector3 cam = Vector3.Normalize (camera.transform.forward);
				Vector3 archer = Vector3.Normalize (this.gameObject.transform.position);
				// Assign angles
				angle = Vector3.Dot (cam, archer);
				if (gameObject.CompareTag ("Archer"))
						GameInformation.ArcherAngle = angle;
				else if (gameObject.CompareTag ("Melee"))
						GameInformation.MeleeAngle = angle;
				else
						GameInformation.MageAngle = angle;

				// Select character with highest dot product to camera normal
				if (GetComponent<Renderer>().IsVisibleFrom (camera) && angle == Mathf.Max (new float[] {
						GameInformation.ArcherAngle,
						GameInformation.MeleeAngle,
						GameInformation.MageAngle
				})) {
						GetComponent<Renderer>().material.shader = shaderOutline;

						if (gameObject.CompareTag ("Archer"))
								GameInformation.PlayerClass = new BaseRangedClass ();
						else if (gameObject.CompareTag ("Melee"))
								GameInformation.PlayerClass = new BaseWarriorClass ();
						else
								GameInformation.PlayerClass = new BaseMageClass ();
				} else {
						GetComponent<Renderer>().material.shader = shaderNoOutline;
				}

		}
}
