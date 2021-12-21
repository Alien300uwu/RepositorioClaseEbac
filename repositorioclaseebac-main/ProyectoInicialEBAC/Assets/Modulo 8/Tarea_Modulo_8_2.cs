using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8_2 : MonoBehaviour
{

    int cero = -2;


    // Start is called before the first frame update
    void Start()
    {
        string NumeroS1 = "1980";
        string NumeroS2 = "8172";
        

        int A_Int;
        int B_Int;
        int Suma;


        
        int.TryParse(NumeroS1.ToString(), out A_Int);
        int.TryParse(NumeroS2.ToString(), out B_Int);


        //Suma de strings
        Suma = A_Int + B_Int;
        Debug.Log(Suma);
        //Debug.Log(NumeroS1);
        //Debug.Log(NumeroS2);


        //Eliminar los 5 primeros caracteres
        int Letras = 5;
        string Oracion_2 = "Eliminar los 5 primeros caracteres";
        string Int_Para_Oracion = Oracion_2.Substring(Letras);
        Debug.Log(Int_Para_Oracion);

        
        // Convetir float a string
        float Numero_Decimal = 9.8066F;
        Numero_Decimal.ToString();
        Debug.LogWarning(Numero_Decimal);


        //Separar Nombre Con substring
        string NombreCompleto = "Paolo Martini Bellot";

        string Nombre = NombreCompleto.Substring(0, 5); //Debug.LogWarning(Nombre);
        string Apellido_P = NombreCompleto.Substring(5, 9); //Debug.LogWarning(Apellido_P);
        string Apellido_M = NombreCompleto.Substring(13); //Debug.LogWarning(Apellido_M);


        //Nombre en lista
        string[] juntar = NombreCompleto.Split(' ');
        foreach(var esp in juntar)
        {
            Debug.LogError($"{esp}");
        }
    

    }

    // Update is called once per frame
    void Update()
    {
        char Letras;
        string Oracion = "Saludos Hombre Pajaro";
        int Letras_Par = cero += 2;
        
            

        if(Letras_Par < 21)
        {
        Letras = Oracion[Letras_Par];
        Debug.Log(Letras);
        }

    }
    private void FixedUpdate()
    {

    }
}
