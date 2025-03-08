using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    // Start is called before the first frame update
    //Public Attributes 
    public List<GameObject> objectList = new List<GameObject> ();
   public  GameObject Explosionprefabs;
public DataKPI dataKPI;
   private void Awake()
    {
        
    }
public void AddObject(GameObject ball){
    objectList.Add(ball);
    if(objectList.Count>5)
        {
           ExplosionAll();
        }
    }

    private  void ExplosionAll()
    {
        for (int i = 0; i < objectList.Count; i++)
        {
            Destroy(objectList[i]);
            Instantiate(Explosionprefabs,objectList[i].transform.position,Quaternion.identity);
        }
        objectList.Clear();
         if(dataKPI!=null){
            dataKPI.SendData();
        }
    }
}
