                                                                                   using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
public class Juego_ahorcado : MonoBehaviour
{
   string palabra_secreta="cascaron";
    public string jugador="";
    public bool comprobar_palabra;
    public bool comprobar_letra;
    string palabra_oculta;

    //public GameObject [] vidas = new GameObject[5];
   public  int vidas=5;
    char letra;
    // Start is called before the first frame update
    void Start()
    {
        palabra_oculta="";
         foreach (char item in palabra_secreta)
         {
             palabra_oculta+='*';
             
         }
         
        jugador=string.Empty;
        comprobar_palabra=false;
        comprobar_letra=false;
        print("Resuelve la palabra");
    }

    // Update is called once per frame
    void Update()
    {
        if(comprobar_letra){
             
            Comprobar_letra();
            comprobar_letra=false;
           
        }
        if(comprobar_palabra){
            Resolver_Palabra();
            comprobar_palabra=false;
        }
                
       
    }

    void Comprobar_letra(){    

        string palabra_Oculta_temp=null;

            if(jugador.Length==1){
                
                letra=char.Parse(jugador);

                if(palabra_secreta.Contains(letra)){
                    
                           
                        
                    for (int i = 0; i < palabra_oculta.Length; i++)
                    {
                         if(palabra_secreta[i]==letra){

                                palabra_Oculta_temp+=""+letra;

                        }else{
                                palabra_Oculta_temp+=palabra_oculta[i];
                            }
            
                    }
                    
                        palabra_oculta=palabra_Oculta_temp;
                        print("La palabra si contiene la letra "+palabra_oculta);  
                }else if(vidas>0){

                    print("Lo siento no  esta la letra en la palabra, pierdes una vida");
                    vidas--;

                }else{
                    print("Lo siento has perdido todas las vidas");
                }
                
            }
        if(jugador==palabra_oculta){

            print("Enhorabuena has ganado!");

            }

    }
    void Resolver_Palabra(){
        if(jugador==palabra_secreta){

            print("Enhorabuena has adivinado la palabra secreta!");

        }else{

            vidas=0;
            print("Lo siento, pero no es la palabra secreta, has perdido todas las vidas");
           
        }

    }
}
