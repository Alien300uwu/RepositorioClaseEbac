using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    private void Awake()
    {
        Debug.Log("Primera prueba de Awake");   
    }
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo paso");
        
        Debug.LogWarning("Esto no es un error");
        Debug.LogError("Esto esta mal xd");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("Hola Desde Update");
        Debug.Log("Esto es desde Void Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed Update cada 50 frames");
        Debug.LogError("Error cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
        Debug.LogError("Error se esta cambiando");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
        Debug.LogError("El objeto no debería ser activado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha isdo inhabilitado");
        Debug.LogError("Esto es un error que indica que el objeto fue eliminado");
    }
}
