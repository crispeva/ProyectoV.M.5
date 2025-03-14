using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject HelpItem;
    public GameObject Cube;
    public DataKPIFinal dataKPI;
    UnityEngine.Vector3 newPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Drop();
    }
    public GameObject Drop(){
        //Guardar la posicion del ultimo objeto creado
         if(Input.GetKeyDown(KeyCode.Space)){
            newPosition = Cube.transform.position;
            newPosition.x+=1;
          HelpItem=Instantiate(HelpItem, newPosition, UnityEngine.Quaternion.identity);

            if(dataKPI!=null){
                dataKPI.SendData();
                
            }
            
        }
        return HelpItem;
    }
}
