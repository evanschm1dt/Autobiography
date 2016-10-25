using UnityEngine;
using System.Collections;

public class swarmControl : MonoBehaviour {

	public float swarmX;
	public float swarmY;
	public Transform player;
	// Use this for initialization
	void Start () {
		
	
	}

	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3 (0, 0, -4) * Time.deltaTime;
		swarmX = player.GetComponent<charControl> ().xPos;
		swarmY = player.GetComponent<charControl> ().yPos;
		transform.position = new Vector3 (swarmX, swarmY, transform.position.z);


}
}
