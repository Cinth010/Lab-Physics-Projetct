using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

	public Rigidbody rb;


	void Update()
	{
		rb.AddForce(0,0,-30);	
	}
		
	


}
