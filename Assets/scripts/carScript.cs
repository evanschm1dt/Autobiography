using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class carScript : MonoBehaviour {
	public Transform playerPos;
	public Transform carPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((playerPos.position - carPos.position).magnitude < 7f) {
			SceneManager.LoadScene ("win");
		}
	}
}
