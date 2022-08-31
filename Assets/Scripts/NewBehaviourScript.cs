using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 accellerationVector;
	public Vector3 velocityVector2;
    
	//Start is called before the first frame update
	
	void Start() 
	{
		
	}
	
	//Update is called once per frame
	void FixedUpdate() 
	{
		UpdateVelocity();
		
        // sorvete
		transform.position += velocityVector2 * Time.deltaTime;
	}
	
	void UpdateVelocity() 
	{
	
		velocityVector2 += accellerationVector * Time.deltaTime;
	}
}
