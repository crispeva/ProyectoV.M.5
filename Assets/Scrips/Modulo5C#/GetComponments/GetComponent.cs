using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]//Este script necesita un componente Renderer
public class NewBehaviourScript : MonoBehaviour
{
    public Color color;
    // Update is called once per frame
    void Update()
    {
        //Si se presiona la tecla R, el color del objeto se vuelve rojo
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
            GetComponentInChildren<Head>().AddForce(500);//Se obtiene el componente Head y se llama al metodo AddForce
            GetComponentInChildren<MeshRenderer>().enabled = false;//Se desactiva el MeshRenderer del objeto hijo
            GetComponentInChildren<Head>().transform.Translate(0,0,1);//Se mueve el objeto hijo
            Camera.main.fieldOfView = 60;//Se cambia el campo de vision de la camara principal
        }
    }
}
