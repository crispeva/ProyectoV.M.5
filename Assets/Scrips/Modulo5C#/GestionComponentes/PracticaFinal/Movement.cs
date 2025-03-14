using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [System.Serializable]
    public struct movement{
  
    }

   public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovementCube();
    }

    public void CubeColors(){

    }
    public void MovementCube(){
        
            
           transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
           transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }
   
}

