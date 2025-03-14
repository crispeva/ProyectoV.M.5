using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Juego_poker : MonoBehaviour
{
    
     // ArrayList cubilete_poker =  new ArrayList () {6,6}; 
    char[] dados= new char[]{'7','8','J','K','A','Q'};
    char[] jugador= new char[6];
     public bool[] dadosSeleccion= new bool[6];
    public bool tirarDados;
    public bool reset=false;
    int contador_dados=0;
 string tirada_de_dados=null;
   
    void Start()
    {
        contador_dados=0;
        dadosSeleccion= new bool[]{true,true,true,true,true,true};
      
        
    }

    // Update is called once per frame
    void Update()
    {
         if(tirarDados){
        tiradas();
       }else if(reset){
            contador_dados=0;
            dadosSeleccion= new bool[]{true,true,true,true,true,true};
            reset=false;
            print("Haga sus nuevas tiradas:");
       }
    }

    void tiradas(){
        //print(numero_tiradas);
        //jugador[contador_dados]= dados[UnityEngine.Random.Range(0,5)];
        
         tirarDados=false;
         contador_dados++;
        tirada_de_dados=null;
        for (int i = 0; i < dados.Length; i++)
        {
            if(dadosSeleccion[i]){
                jugador[i]=dados[UnityEngine.Random.Range(0,5)];
                    
            }
            
            if(i<dados.Length-1){
                tirada_de_dados +=jugador[i]+",";   
            }else{
                tirada_de_dados +=jugador[i]; 
            }
            
        }
        
         print("El valor del dado es:"+contador_dados+")"+tirada_de_dados);
}
}
