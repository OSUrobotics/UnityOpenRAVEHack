using UnityEngine;
using System.Collections;

public class groundPlane : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Object Entered the Trigger");
	}
	
//	void OnTriggerStay (Collider other)
//	{
//		Debug.Log ("Object is within Trigger");
//	}
	
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Object Exited the Trigger");
	}
}