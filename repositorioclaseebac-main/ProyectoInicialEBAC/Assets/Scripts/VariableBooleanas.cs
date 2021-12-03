using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableBooleanas : MonoBehaviour
{
    bool Variable1;
    bool Variable2;
    bool Variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }



    // A B C   OR   AND    ((a or b) and c) ((a or b) or c)
    // 1 1 1   1   1       1                        1
    // 1 1 0   1   0       0                        1
    // 1 0 1   1   0       1                        1
    // 1 1 0   1   0       0                        1
    // 0 1 1   1   0       1                        1
    // 0 1 0   1   0       0                        1
    // 0 0 1   0   0       0                        1
    // 0 0 0   0   0       0                        0



    // Start is called before the first frame update
    void Start()
    {
        Variable1 = true;
        Variable2 = false;
        Variable3 = false;
        if ((Variable1 || Variable2) && Variable3)
        {
            Debug.Log("la operacion 1 es verdadero");
        }
        if ((Variable1 || Variable2) || Variable3)
        {
            if (Variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadero");
        }
        if ((Variable3 && Variable2) || Variable1)
        {
            Debug.Log("la operacion 3 es verdadera");
        }

        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        //if(valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);
        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.azul when Variable1 == true:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    default:
        //        Debug.Log("Ese no es un color valido");
        //        break;

        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
}
