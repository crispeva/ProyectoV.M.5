using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ListaSpawners : MonoBehaviour
{
    //Private Attributes
    private Spawner spawner;
     //Public Attributes
    public DataKPIFinal dataKPI;
    public List<GameObject> SpawnList = new List<GameObject>();
    GameObject NewSpawner;
    // Start is called before the first frame update
    void Awake()
    {
        spawner=GetComponent<Spawner>();
        NewSpawner=spawner.HelpItem;
    }
    // Update is called once per frame
    void Update()
    {
       AddList();
        
    }
    void AddList(){
        if(spawner!=null & spawner.HelpItem!=NewSpawner){
           NewSpawner=spawner.HelpItem;

            SpawnList.Add(spawner.Drop());
           if(dataKPI!=null){
            
                dataKPI.SendData();

            }

        }
    }
}
