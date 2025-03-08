using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList_1 : MonoBehaviour
{
    // Start is called before the first frame update
    ArrayList array=new ArrayList();
    void Start()
    {
        array.Add("Uno");
        array.Add(2);
        array.Add("a");
        array.Add(1.2);
        print("Tamaño lista"+array.Count);

        foreach (var item in array)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
