using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KPIMaze{
LastSpanwPoint=0,
LastColor=1,
CountSpawnPoint=2,
}

public class DataKPIFinal : MonoBehaviour
{
    public KPIMaze KPIData;
    private DataControl dataControl;
    void Awake()
    {
        dataControl = FindAnyObjectByType<DataControl>();
         if (dataControl != null)
        {
            Debug.Log("DataControl encontrado.");
        }
        else
        {
            Debug.Log("No se encontró DataControl.");
        }
        //dataControl=GetComponent<DataControl>();
    }
    public void SendData(){
         print(" KPIDATA "+ KPIData);
        dataControl.CollectData(KPIData);
    }
    
}
