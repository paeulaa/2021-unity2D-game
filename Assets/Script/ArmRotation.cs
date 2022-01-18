using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//calculate the vector from arm pivot to mouse position
		Vector3 diff = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;

		//get the degree between diff and X axis, and convert to value from rad to degree
		float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

		// //fix the rotZ when character facing left
		// if (transform.parent.localScale.x < 0.0f) rotZ += 180;
		
		// if(rotZ > 30){
		// 	rotZ = 30;
		// }else if(rotZ < -60){
		// 	rotZ = -60;
		// }

		//set the arm rotation
		transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
	}
}
