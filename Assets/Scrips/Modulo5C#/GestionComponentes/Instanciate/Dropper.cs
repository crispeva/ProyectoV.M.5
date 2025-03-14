using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public float dropTime = 2.0f;
    public GameObject BallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Drop", 0.0f, dropTime);
    }
    void Drop()
    {
        //Instanciamos la bola en la posición del Dropper y con la rotación por defecto
       GameObject ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
    }
}
