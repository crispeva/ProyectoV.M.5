using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    private float cuentatras =0;
    public float explosion=0;
    int contador=0;
  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cuentatras+=Time.deltaTime;
        if(cuentatras>=1){
            print("TIC!");
            
            cuentatras=0;
            contador++;
            explosion_nuclear();
        }
            
        
    }

    void explosion_nuclear(){
        if(contador>=explosion){
            print("BOOOOM!");
            Destroy(gameObject);
        }
    }
}
