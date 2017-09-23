using UnityEngine;
using System.Collections;

public class PinSetter : MonoBehaviour {

	// Use this for initialization
	Rigidbody rg;
	float distancetoRaise=40.0f;
	void Start () {
		rg = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//rigidBody.useGravity = true;
	}
	public void RaisePins()
	{
		//Raise Standing pins
		Debug.Log ("Raise Pins");
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
		{
			
			//Rigidbody rb=GetComponent<Rigidbody>();
			//rb.useGravity=false;
			pin.transform.Translate(new Vector3(0,distancetoRaise,0),Space.World);
			//pin.GetComponent<Rigidbody>().useGravity=false;
			
			
			
		}
		
	}
	
	public void Lower(){
		
		Debug.Log("Lower");
		
		//transform.position = startPos;
		
		//ridgidbody.useGravity = true;
		
	}
	
	
	public void RenewPins()
	{
		Debug.Log ("Renew Pins");
	}



}
