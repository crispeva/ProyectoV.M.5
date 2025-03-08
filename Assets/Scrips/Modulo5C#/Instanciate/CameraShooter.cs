using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShooter : MonoBehaviour
{
    //Sirve para que el objeto no se duplique
    //Sirve tambien para poner etiquetas a los objetos en el inspector
    [Header("Velocidad de rotacion")]
    public float SpeedRotation = 100.0f;
      [Header("Shoot")]
    public Transform spawnPoint;
    public Ball BallPrefab;
    public float shootForce = 1000.0f;
    private Quaternion initialRotation;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Start()
    {
        Invoke(nameof(InitialConfiguration), 1.0f);
        //Sirve para que el cursor no se salga de la pantalla
        Cursor.lockState=CursorLockMode.Confined;
        //Sirve para que el cursor no se vea
        Cursor.lockState=CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de la camara
        transform.Rotate(Input.GetAxis("Mouse Y")*Time.deltaTime*SpeedRotation*Vector3.left);
        transform.Rotate(Input.GetAxis("Mouse X")*Time.deltaTime*SpeedRotation*Vector3.down);
        transform.localRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

        //Disparo de la pelota
        if(Input.GetMouseButtonDown(0))
        {
           Ball ball  = Instantiate(BallPrefab, transform.position, transform.rotation);
            ball.myrigidbody.AddForce(transform.forward*shootForce);
        }
    }
    void InitialConfiguration()
    {
        initialRotation = transform.rotation;
    }
}
