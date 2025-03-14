using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            print("Te pasastes el laberinto Felicidades!!");
            Destroy(other.gameObject);  // Destruir este objeto
        }
    }
        
    
}
