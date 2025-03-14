using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incremento_binario : MonoBehaviour
{
    int number =5;
    int number2 =10;
    string cadena= string.Empty;
    // Start is called before the first frame update
    void Start()
    {
        number=number >>1;
            print(number);
        cadena= Convert.ToString(number2,2);//Si se requiere hexadecimal, se cambiaria el 2 por 16
            print(cadena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
