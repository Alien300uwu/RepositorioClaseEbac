using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8 : MonoBehaviour
{

    int Flan = 2;
    int crepa = 1;
    float Pastel = 0;
    int Crema = 0;

    Color CambioPar = Color.red;
    Color CambioImpar = Color.blue;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {

        Flan *= crepa;
        //Debug.LogWarning("El Valor del Flan actual es= " + Flan);

        crepa ++;
        //Debug.LogError("El Valor de Crepa actual es= " + crepa);


        Pastel = Pastel + 3;
        Crema = (int)Pastel;
        
        

        if (Crema % 2 == 0)
        {
            GetComponent<MeshRenderer>().material.color = CambioPar;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = CambioImpar;
        }




    }
}
