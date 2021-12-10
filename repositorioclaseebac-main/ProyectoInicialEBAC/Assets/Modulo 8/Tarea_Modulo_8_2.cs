using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8_2 : MonoBehaviour
{
    
    string[] palabras =
    {
        "Alpha",
        "Beta",
        "Chalie",
        "Delta",
        "Echo"
    };

    int a = 0;
    int b = 5;
    int seleccionador;

    string nombre = "PaoloMartiniBellot";
   
    
    Color ColorDePalabra = Color.blue;
    string Seleccionador;

    // Start is called before the first frame update
    void Start()
    {

        


        Debug.Log(palabras [0]);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void FixedUpdate()
    {

        seleccionador = Random.Range(a, b);
        Debug.LogWarning(seleccionador);


    }
}
