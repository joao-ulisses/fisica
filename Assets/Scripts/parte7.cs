using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parte7 : MonoBehaviour
{
    public Vector3 accelerationVector;
    public Vector3 relativeForceVector;
    public Vector3 velocityVector2;
    public float massa = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        velocityVector2 += accelerationVector * Time.deltaTime;

    }

    void Posicao()
    {

        transform.position += velocityVector2 * Time.deltaTime;

    }

}
