using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSuelo : MonoBehaviour
{
    public float velocidadJuego = 1;
    
    private void FixedUpdate()
    {
        transform.Translate(Time.deltaTime * -velocidadJuego, 0, 0);
    }
}

