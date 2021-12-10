using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8 : MonoBehaviour
{

    int Flan = 0;
    int crepa = 0;
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
        Flan = Flan + 5;
        Debug.LogWarning("El Valor del Flan actual es= " + Flan);

    }
    private void FixedUpdate()
    {
        crepa = crepa + 2;
        Debug.LogError("El Valor de Crepa actual es= " + crepa);


        Pastel = Pastel + 3;
        Crema = (int)Pastel;
        Debug.Log(Crema);
        

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
