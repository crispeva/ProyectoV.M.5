using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Tragaperras : MonoBehaviour
{
   char [] valores =  {'A','B','C','D'};
   char rodillo1;
   char rodillo2;
   char rodillo3;
   public bool pulsar=false;
   public int saldo=1000;
   public int coste=300;
   int premio;
    void Start()
    {
        print("Buenas mis jugadores realiza una tirada, si te sale una linea con el mismo caracter ganas premio");
    }
    // Update is called once per frame
    void Update()
    {
        //Escanear el estado del botón.
        if(pulsar){
            tiraRodillos();
            pulsar=false;
        }
    }
    void tiraRodillos(){
        if((saldo-coste)<0){

            print("Lo siento  no te queda saldo suficiente para jugar: "+ saldo+"€");

        }else{
            rodillo1=valores[UnityEngine.Random.Range(0,valores.Length-1)];
            rodillo2=valores[UnityEngine.Random.Range(0,valores.Length-1)];
            rodillo3=valores[UnityEngine.Random.Range(0,valores.Length-1)];
            print("Rodillo_1: "+rodillo1+" Rodillo_2: "+rodillo2+" Rodillo_3: "+rodillo3);
            saldo-=coste;
            if(rodillo1==rodillo2 & rodillo1==rodillo3){
                premio=(saldo*90)/coste;
                saldo+=premio;
                print("Oleee has ganado un premio, que seria : "+premio+" que se junto a tu sueldo actual es "+saldo+"€");
            }else{
                print("Has tenido mala suerte, vuelvo a tirar");
            }
        }

    }
}
