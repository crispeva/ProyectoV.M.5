using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropprCourrutine : MonoBehaviour

{
        public float dropTime = 1f;
    public GameObject BallPrefab;
    public DataKPI dataKPI;

    Array myArray;
    Lista lista;
    // Start is called before the first frame update
    private void Awake()
    {
        myArray = GetComponent<Array>();
        lista = GetComponent<Lista>();
    }
    void Start()
    {
        float repeatRate = UnityEngine.Random.Range(1f, 3f);
        //Se llama de la siguiente manera
        StartCoroutine(Drop(repeatRate));
    }

    // Update is called once per frame
  IEnumerator Drop (float rateTime){

    //Se hace espera de un frame
    //yield return null;

    //Siempre con un while
    while(true){
        //Con esto espera por segundo en vez de por frame
        yield return new WaitForSeconds(rateTime);
        GameObject ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
        lista.AddObject(ball);
        if(myArray!=null){
            myArray.AddObject(ball);
        }
        if(dataKPI!=null){
            dataKPI.SendData();
        }
        
    }
  }
}
