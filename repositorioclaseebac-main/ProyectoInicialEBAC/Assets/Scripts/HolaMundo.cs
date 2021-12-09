using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo paso");
        
        Debug.LogWarning("Esto no es un error");
        Debug.LogError("Esto esta mal xd");
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("Hola Desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha isdo inhabilitado");
    }
}
