using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] ObjectArray;
    private int index =0;
   public void AddObject(GameObject newObject){
        if(index < ObjectArray.Length){
            ObjectArray[index]=newObject;
            index++;
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
