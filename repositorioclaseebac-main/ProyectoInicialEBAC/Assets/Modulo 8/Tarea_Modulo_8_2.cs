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

        Suma = A_Int + B_Int;
        Debug.Log(Suma);
        //Debug.Log(NumeroS1);
        //Debug.Log(NumeroS2);




        int Letras = 5;
        string Oracion_2 = "Eliminar los 5 primeros caracteres";
        string Int_Para_Oracion = Oracion_2.Substring(Letras);
        Debug.Log(Int_Para_Oracion);

    }

    // Update is called once per frame
    void Update()
    {
        char Letras;
        string Oracion = "Saludos Hombre Pajaro";
        int Letras_Par = cero += 2;
        
        Letras = Oracion[Letras_Par];
        Debug.Log(Letras);
        if(Letras_Par > 20)
        {
        }
    }
    private void FixedUpdate()
    {

    }
}
