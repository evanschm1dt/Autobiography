using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class charControl : MonoBehaviour {

	CharacterController cController;


	float jumpTimer;
	public float xPos;
	public Transform playerPos;
	public Transform swarmPos;
	public Text deathMessage;
	// Use this for initialization
	void Start () {
		cController = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");


		cController.SimpleMove (transform.forward * inputY * 8f + transform.right * inputX * 8f);


		if (Input.GetKeyDown (KeyCode.Space)) {
			jumpTimer = Time.time + 1.2f;
		}
		if (Time.time < jumpTimer) {
			cController.Move (Vector3.up * 0.1f);
		}
		xPos = transform.position.x;

		if ((playerPos.position - swarmPos.position).magnitude < 8f) {
			deathMessage.text = "You've been stung";
		}
	}
}
