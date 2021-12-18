using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea_Modulo_8_2 : MonoBehaviour
{



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
        Debug.Log(NumeroS1);
        Debug.Log(NumeroS2);

        string Oracion = "Saludos Hombre Pajaro";
        Debug.Log(Oracion);
        
        string Oracion_2 = "Eliminar los 5 primeros caracteres";
        string Int_Para_Oracion = Oracion_2.Substring(0, 34);
        Debug.Log(Int_Para_Oracion);
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {

    }
}
