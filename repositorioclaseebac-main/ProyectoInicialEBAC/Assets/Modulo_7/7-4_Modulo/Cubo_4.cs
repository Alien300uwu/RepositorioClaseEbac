using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_4 : MonoBehaviour
{

    public Cubo_0 Cubo0;
    public Cubo_3 Cubo3;
    public Cubo_2 Cubo2;

    Color Papas = Color.magenta;
    Color Pizza = Color.black;


    bool a;
    bool b;
    bool c;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        a = Cubo0.ValorDeCubo_0;
        b = Cubo3.variable_publica_para_el_4;
        c = Cubo2.ValorCubo3;

        //Debug.LogError(a);
        //Debug.LogError(b);
        //Debug.LogError(c);
        if (a == true)
        {
            if ((b && c) == false)
            {
                GetComponent<MeshRenderer>().material.color = Pizza;

            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Papas;
            }
        }


    }
}
