using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repositions : MonoBehaviour
{
    
    public float velocidadJuego = 1;
    public Transform emphtyReposicionar;
    
    private void Update()
    {   
        transform.Translate(Time.deltaTime * -velocidadJuego, 0, 0);

        if(this.transform.position.x <= -10)
        {
            float posicionEmphty =  emphtyReposicionar.position.x + 5;
            print("el suelo tendría que reposicionarse");
            //this.transform.Translate(new Vector3(this.transform.position.x,-30,this.transform.position.z),Space.World);
          
            this.transform.position = new Vector3(
                posicionEmphty,
                this.transform.position.y,
                 this.transform.position.z
                );
            
            print("la posicion del empty es: " + posicionEmphty);
            print("la posicion de la plataforma es : " + this.transform.position.z);
            print("----------------------------------------------------------------");     
        }
    }
}
