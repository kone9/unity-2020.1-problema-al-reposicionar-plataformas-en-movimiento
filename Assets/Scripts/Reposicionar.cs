using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposicionar : MonoBehaviour
{
    public Transform reposicionar;
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x <= -15)
        {
            float Acomodar =  reposicionar.position.x;
            print("el suelo tendría que reposicionarse");
            //this.transform.Translate(new Vector3(this.transform.position.x,-30,this.transform.position.z),Space.World);
            
            this.transform.position = new Vector3(
                Acomodar,//El objeto se reposiciona en donde esta el empty
                this.transform.position.y,
                this.transform.position.z
                );
            
            print("la posicion del empty es: " + Acomodar);
            print("la posicion de la plataforma es : " + this.transform.position.x);
            print("----------------------------------------------------------------");     
        }
    }
    
}
