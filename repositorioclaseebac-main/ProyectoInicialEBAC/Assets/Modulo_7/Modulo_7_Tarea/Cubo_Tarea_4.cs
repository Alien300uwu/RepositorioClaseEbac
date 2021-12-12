using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Tarea_4 : MonoBehaviour
{

    public Cubo_Tarea_3 Alfa;
    public Cubo_Tarea_2 Beta;
    Color Ensalada = Color.cyan;
    Color Postre = Color.gray;
    public bool Valor_del_cubo_4; //Esto es para que cambie el valor en el cubo 5 y no se quede en falso
    bool Super;
    bool Hiper;

    // Start is called before the first frame update
    void Start()
    {
        Valor_del_cubo_4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError(Super);
        //Debug.LogError(Hiper);
        //Debug.Log(Valor_del_cubo_4);

    }

    private void FixedUpdate()
    {

        Super = Alfa.Valor_del_cubo_3;
        Hiper = Beta.falsa;

        if (Super && Hiper)
        {
            GetComponent<MeshRenderer>().material.color = Ensalada;
            Valor_del_cubo_4 = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Postre;
            Valor_del_cubo_4 = false;
        }
    }
}
