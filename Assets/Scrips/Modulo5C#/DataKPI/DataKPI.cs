using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public enum KPIType{
        CollisionKPI=0,
        SpawnedKPI=1,
        ExplosionKPI=2,

    }
public class DataKPI : MonoBehaviour
{
    public KPIType customKPI;
    private DataController dataController;
    void Awake()
    {
        //Coge solo el primer componente de DataController
        dataController = FindAnyObjectByType<DataController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void SendData(){
        print(" KPIDATA "+ customKPI);
        dataController.CollectData(customKPI);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
