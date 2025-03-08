using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [System.NonSerialized]
    public  Rigidbody myrigidbody;
    public DataKPI dataKPI;
    // Start is called before the first frame update
    void Awake()
    {
        myrigidbody = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
            if(dataKPI!=null){
            dataKPI.SendData();
        }
    }

        
    
    
}
