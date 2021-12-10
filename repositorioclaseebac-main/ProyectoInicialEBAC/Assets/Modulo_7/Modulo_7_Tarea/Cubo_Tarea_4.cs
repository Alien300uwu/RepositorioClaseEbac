using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Tarea_4 : MonoBehaviour
{

    public Cubo_Tarea_3 Alfa;
    public Cubo_Tarea_2 Beta;
    Color Ensalada = Color.cyan;
    Color Postre = Color.yellow;
    bool Super;
    bool Hiper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError(Super);
        Debug.LogError(Hiper);

    }

    private void FixedUpdate()
    {

        Super = Alfa.Valor_Parar_4;
        Hiper = Beta.ValorDelCubo2;

        if (Super && Hiper)
        {
            GetComponent<MeshRenderer>().material.color = Ensalada;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Postre;
        }
    }
}
