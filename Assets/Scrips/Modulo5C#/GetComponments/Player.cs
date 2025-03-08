using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Body body;
    private Head head;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponentInChildren<Body>(true);
        head = GetComponentInChildren<Head>(true);
        body.gameObject.SetActive(true);
        head.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            head.AddForce(500);
            body.transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*5,0,Input.GetAxis("Vertical")*Time.deltaTime*5);
        }
    }
}
