using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableChart_Ejercicio_clase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '6';
        int valorEntero = 0;
        if (!int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.LogError("Eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde mi casa xd";
        string miSegundoString = miString.ToUpper();
        string tercetString = miString + " " + miSegundoString;
        string ejemploEscape ="C:\\Users\\Diego\\Documento";
        miCaracter = miString[12];
        string miNombre = "Paolo";
        string Apellido = "Martini Bellot";
        string PrimerApelido = Apellido.Substring(0,7);
        string Salida = $"Mi nombre es: {miNombre} y mis Apellidos son {Apellido}";
        int logitud = miString.Length;
        Debug.Log(PrimerApelido);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
