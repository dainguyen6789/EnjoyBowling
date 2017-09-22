using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Camera cmr;
	public Rigidbody rb;

	public float offset;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		offset = cmr.transform.position.z - transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rb.velocity=new Vector3(0,0,500.0f);

		}
		cmr.transform.position = new Vector3(cmr.transform.position.x,cmr.transform.position.y,offset + transform.position.z);
		
	}
}
