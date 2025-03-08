using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class DataControl : MonoBehaviour
{
    [System.Serializable]
    //Creamos el struct con variables
    public struct DataBucket{
        public Vector3 LastSpawn;
        public Color LastColor;
        public int CountSpawnPoint;
       
        public void Save(string dataPath){
            string jsonString = JsonUtility.ToJson(this);
            File.WriteAllText(dataPath,jsonString);
        }

    }
       public  GameObject Spawner;
       public  GameObject Cube;
        Color CubeColor;
       public  DataBucket dataBucket;
    void Start()
    {
        dataBucket.LastSpawn=Vector3.zero;
        dataBucket.LastColor=Color.black;
        dataBucket.CountSpawnPoint=0;
    }

    public void CollectData(KPIMaze dataType){
        Renderer cubeRenderer = Cube.GetComponent<Renderer>();
       Transform SpawnPosition=Spawner.GetComponent<Transform>();
        CubeColor=cubeRenderer.material.color;

         switch(dataType){
            
            case KPIMaze.LastSpanwPoint:
            dataBucket.LastSpawn=SpawnPosition.position;
            break;
            case KPIMaze.LastColor:
            dataBucket.LastColor=CubeColor;
            break;
            case KPIMaze.CountSpawnPoint:
            dataBucket.CountSpawnPoint++;
            break;
        }
   }
    private void OnDestroy()
    {
        dataBucket.Save(Application.dataPath+"/Data/data.json");
    }
}
