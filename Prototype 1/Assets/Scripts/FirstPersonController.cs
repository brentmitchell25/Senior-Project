using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {
	public float movementSpeed = 10.0f;
	public float mouseSensitivity = 2.0f;
	float verticalRoation = 0;
	public float upDownRange = 60.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		verticalRoation = verticalRoation - Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRoation = Mathf.Clamp (verticalRoation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRoation, 0, 0);

		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

		Vector3 speed = new Vector3 (sideSpeed,0,forwardSpeed);
		speed = transform.rotation * speed;
		CharacterController cc = GetComponent<CharacterController>();
		cc.SimpleMove (speed);
	}
}
