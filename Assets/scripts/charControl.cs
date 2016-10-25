using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class charControl : MonoBehaviour {

	CharacterController cController;


	float jumpTimer;
	public float xPos;
	public float yPos;
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


		//cController.SimpleMove (transform.forward * inputY * 15f + transform.right * inputX * 15f);
		cController.SimpleMove (new Vector3 (0, 0, 1) * inputY * 15f + new Vector3 (1, 0, 0) * inputX * 15f);



		xPos = transform.position.x;
		yPos = transform.position.y;

		if ((playerPos.position - swarmPos.position).magnitude < 4f) {
			SceneManager.LoadScene ("end");

		}

		if (Input.GetKey (KeyCode.W)) {
			
			transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (Input.GetKey (KeyCode.S)) {

			transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {

			transform.eulerAngles = new Vector3 (0, -90, 0);
		}
		if (Input.GetKey (KeyCode.A)) {

			transform.eulerAngles = new Vector3 (0, 90, 0);
		}

		Camera.main.transform.position = transform.position + new Vector3 (0, 4, -6);

	}
}
