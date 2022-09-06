using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Vector3 accellerationVector;
	public Vector3 velocityVector2;
	
	//Update is called once per frame
	void FixedUpdate() 
	{
		UpdateVelocity();
		// sorvetao
		transform.position += velocityVector2 * Time.deltaTime + ((accellerationVector * (Time.deltaTime * Time.deltaTime)) / 2);
	}
	
	void UpdateVelocity() 
	{
	
		velocityVector2 += accellerationVector * Time.deltaTime;
	}
}