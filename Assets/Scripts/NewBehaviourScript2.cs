using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    public Vector3 accelerationVector; 
    public Vector3 relativeForceVector;
    public Vector3 velocityVector;
    public float massa = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        //calculo de posicao com forca
        Velocidade();
        Posicao();

    }

    void Aceleracao()
    {

        accelerationVector = relativeForceVector / massa;

    }

    void Velocidade()
    {
        Aceleracao();
        velocityVector += accelerationVector * Time.deltaTime;

    }

    void Posicao()
    {

        transform.position += velocityVector * Time.deltaTime;

    }

}
