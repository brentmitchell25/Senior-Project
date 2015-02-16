using System.Collections;
using UnityEngine;

public class OutlineCharacter : MonoBehaviour
{
		private static Shader shaderNoOutline = Shader.Find ("Diffuse");
		private static Shader shaderOutline = Shader.Find ("Outlined/Diffuse");
		private Camera camera;
		public float angle;

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
				if (renderer.IsVisibleFrom (camera) && angle == Mathf.Max (new float[] {
						GameInformation.ArcherAngle,
						GameInformation.MeleeAngle,
						GameInformation.MageAngle
				})) {
						renderer.material.shader = shaderOutline;

						if (gameObject.CompareTag ("Archer"))
								GameInformation.PlayerClass = new BaseRangedClass ();
						else if (gameObject.CompareTag ("Melee"))
								GameInformation.PlayerClass = new BaseWarriorClass ();
						else
								GameInformation.PlayerClass = new BaseMageClass ();
				} else {
						renderer.material.shader = shaderNoOutline;
				}

		}
}
