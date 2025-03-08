using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColor : MonoBehaviour
{
    //Public Attributes
    public float RateTimeColor;
    //Private Attributes
    private Renderer CubeColor;
    public DataKPIFinal dataKPI;

    // Start is called before the first frame update
    void Awake()
    {
        CubeColor=GetComponent<Renderer>();
    }
    void Start()
    {
        
        StartCoroutine(Cube(RateTimeColor,CubeColor));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        IEnumerator Cube(float RateTimeColor,Renderer CubeColor){
            
            while(true){
                Color targetColor = new Color(Random.value, Random.value, Random.value); 
                CubeColor.material.color=targetColor;
                if(dataKPI!=null){
                dataKPI.SendData();
            }
                yield return new WaitForSeconds(RateTimeColor);
            }
           
        
         
        

    } 
}
