using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hiveScript : MonoBehaviour {
	public Transform playerPos;

	public Transform hivePos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((playerPos.position - hivePos.position).magnitude < 2f) {
			SceneManager.LoadScene ("end");
		}
	}
}
