using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {
	public Camera cmr;
	public Rigidbody rb;

	public float offset;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		offset = cmr.transform.position.z - transform.position.z;
	}

	public void Launch (Vector3 speed)
	{
		//if (Input.GetMouseButtonDown (0)) {
			rb.velocity = speed;
		//}

	}
	
	// Update is called once per frame
	void Update () {
		//Launch ();
		if (cmr.transform.position.z < 800) {
			cmr.transform.position = new Vector3 (cmr.transform.position.x, cmr.transform.position.y, offset + transform.position.z);
		}
	}
}
