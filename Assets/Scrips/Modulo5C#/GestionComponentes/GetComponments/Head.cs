using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void AddForce(float force)
    {
        GetComponent<Rigidbody>().AddForce(0,force,0);
    }
}
