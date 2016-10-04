using UnityEngine;
using System.Collections;

public class swarmControl : MonoBehaviour {

	public float swarmX;
	// Use this for initialization
	void Start () {
		
	
	}

	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3 (0, 0, -5) * Time.deltaTime;
		//swarmX = gameObject.GetComponent<charControl> ().xPos;
	


}
}
