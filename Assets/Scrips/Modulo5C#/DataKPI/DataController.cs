using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class DataController : MonoBehaviour
{
    //Si queremos hacer publico struct y se que se vean las varaibles
    [System.Serializable]
    //Creamos el struct con variables
    public struct DataBucket{
        public int explosionCount;
        public int spawnCount;
        public int collisionCount;

        public void Save(string dataPath){
            string jsonString = JsonUtility.ToJson(this);
            File.WriteAllText(dataPath,jsonString);
        }

    }
    //Se inicializa
    public DataBucket bucket;
    // Start is called before the first frame update
    void Start()
    {
        bucket.collisionCount=0;
        bucket.explosionCount=0;
        bucket.spawnCount=0;
    }
    //Cuando paremos el juego o lo cerremos se llamara al metodo save
    private void OnDestroy()
    {
        bucket.Save(Application.dataPath+"/Data/data.txt");
    }
    // Update is called once per frame
    //Creamos un metedo para recoger los datos de el script KPIDATA
    public void CollectData(KPIType dataType){
        switch(dataType){
            case KPIType.CollisionKPI:
            bucket.collisionCount++;
            break;
            case KPIType.ExplosionKPI:
            bucket.explosionCount++;
            break;
            case KPIType.SpawnedKPI:
            bucket.spawnCount++;
            break;
        }
   }
}
