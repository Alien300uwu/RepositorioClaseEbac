using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios_De_Ciclos_y_Arreglos : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 1
        int[] arre_1 = new int[0];
        int[] arre_2 = new int[4];
        int[] arre_3 = new int[0];


        //Ejercicio 2
        string[] oracion = new string[] { "El", "sereto", "de", "avanzar", "es", "comenzar" };
        foreach (string pal in oracion)
        {
            string[] Juntar = new string[oracion.Length];
            Debug.Log(Juntar);
        }

        //Ejercicio 3
        int[,] Ejercicio_3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 }};


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
